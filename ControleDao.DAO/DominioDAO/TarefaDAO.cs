using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDao.DAO
{
    public class TarefaDAO : GenericsDAO
    {
        Tarefa tarefa;

        public TarefaDAO()
        {
            enderecoDBEmpresa = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DbControleTarefas;Integrated Security=True;Pooling=False";
        }
        public void SaveDbProvider(Tarefa tarefa)
        {
            string sqlSelecao = @"UPDATE TB_TAREFAS 
                                SET [TITULO] = @TITULO, [DATACRICACAO] = @DATACRICACAO , 
                                    [DATACONCLUCAO] = @DATACONCLUCAO , [PERCENTUAL] = @PERCENTUAL ,
                                    [PRIORIDADE] = @PRIORIDADE
                                WHERE 
                                    [ID] = @ID";

            this.tarefa = tarefa;
            DbExecuteNonQuery(sqlSelecao);
        }

        public void RemoverDbProvider(Tarefa tarefa)
        {
            
            string sqlSelecao = @"DELETE FROM TB_TAREFAS                               
                                WHERE 
                                    [ID] = @ID";

                        this.tarefa = tarefa;
            DbExecuteNonQuery(sqlSelecao);
        }
        public void InsertDbProvider(Tarefa tarefa)
        {          
            string sqlSelecao =@"INSERT  INTO TB_TAREFAS 
                                        ([TITULO], [DATACRICACAO], [DATACONCLUCAO], [PERCENTUAL], [PRIORIDADE])
                                VALUES 
                                        (@TITULO , @DATACRICACAO , @DATACONCLUCAO,  @PERCENTUAL , @PRIORIDADE)";

            this.tarefa = tarefa;
            DbExecuteNonQuery(sqlSelecao);
        }

        public DataTable SelectDbProviderPercentual( bool tipoDeBusca)
        {
            string sqlSelecao ;
            if (tipoDeBusca)
            {
                 sqlSelecao =
                    @"SELECT 
                        [ID], 
                        [TITULO], 
                        [DATACRICACAO], 
                        [DATACONCLUCAO] ,
                        [PERCENTUAL],
                        [PRIORIDADE]
                    FROM 
                        TB_TAREFAS
                    WHERE 
                        Percentual = '100%'";

            }else
            {
                sqlSelecao =
                    @"SELECT 
                        [ID], 
                        [TITULO], 
                        [DATACRICACAO], 
                        [DATACONCLUCAO] ,
                        [PERCENTUAL],
                        [PRIORIDADE]
                    FROM 
                        TB_TAREFAS
                    WHERE 
                        Percentual != '100%'";
            }

            return DbExecuteReader(sqlSelecao);
        }

        public DataTable SelectDbProvider(Tarefa tarefa)
        {          
           string auxPrioridade = "%"+tarefa.Prioridade+"%";
            string sqlSelecao =
                $@"SELECT 
                        [ID], 
                        [TITULO], 
                        [DATACRICACAO], 
                        [DATACONCLUCAO] ,
                        [PERCENTUAL],
                        [PRIORIDADE]
                    FROM 
                        TB_TAREFAS
                    WHERE 
                        PRIORIDADE LIKE '{auxPrioridade}'";

            return DbExecuteReader(sqlSelecao);
        }

        protected override void GerarParametrosInserir(SqlCommand comandoSelecao)
        {
            comandoSelecao.Parameters.AddWithValue("ID", tarefa.Id);
            comandoSelecao.Parameters.AddWithValue("PRIORIDADE", tarefa.Prioridade);
            comandoSelecao.Parameters.AddWithValue("TITULO", tarefa.Titulo);
            comandoSelecao.Parameters.AddWithValue("DATACRICACAO", tarefa.DataCriacao);
            comandoSelecao.Parameters.AddWithValue("DATACONCLUCAO", tarefa.DataConclusao);
            comandoSelecao.Parameters.AddWithValue("PERCENTUAL", tarefa.Percentual);
        }
    }
}