using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDao.DAO
{
    public class Tarefa
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Prioridade { get; set; }
        public DateTime DataConclusao { get; set; }
        public string Titulo { get; set; }
        public string Percentual { get; set; }
    }
    public class TarefaDAO
    {
        public void EditarDbProvider(Tarefa tarefa)
        {
            string enderecoDBEmpresa =
              @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DbControleTarefas;Integrated Security=True;Pooling=False";

            SqlConnection conexaoComBanco = new SqlConnection();
            conexaoComBanco.ConnectionString = enderecoDBEmpresa;
            conexaoComBanco.Open();

            SqlCommand comandoSelecao = new SqlCommand();
            comandoSelecao.Connection = conexaoComBanco;

            string sqlSelecao = @"UPDATE TB_TAREFAS 
                                SET [TITULO] = @TITULO, [DATACRICACAO] = @DATACRICACAO , 
                                    [DATACONCLUCAO] = @DATACONCLUCAO , [PERCENTUAL] = @PERCENTUAL ,
                                    [PRIORIDADE] = @PRIORIDADE
                                WHERE 
                                    [ID] = @ID";

            comandoSelecao.CommandText = sqlSelecao;
            comandoSelecao.Parameters.AddWithValue("ID", tarefa.Id);
            comandoSelecao.Parameters.AddWithValue("PRIORIDADE", tarefa.Prioridade);
            comandoSelecao.Parameters.AddWithValue("TITULO", tarefa.Titulo);
            comandoSelecao.Parameters.AddWithValue("DATACRICACAO", tarefa.DataCriacao);
            comandoSelecao.Parameters.AddWithValue("DATACONCLUCAO", tarefa.DataConclusao);
            comandoSelecao.Parameters.AddWithValue("PERCENTUAL", tarefa.Percentual);

            comandoSelecao.ExecuteNonQuery();
            conexaoComBanco.Close();
        }
        public void RemoverDbProvider(Tarefa tarefa)
        {
            string enderecoDBEmpresa =
              @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DbControleTarefas;Integrated Security=True;Pooling=False";

            SqlConnection conexaoComBanco = new SqlConnection();
            conexaoComBanco.ConnectionString = enderecoDBEmpresa;
            conexaoComBanco.Open();

            SqlCommand comandoSelecao = new SqlCommand();
            comandoSelecao.Connection = conexaoComBanco;

            string sqlSelecao = @"DELETE FROM TB_TAREFAS                               
                                WHERE 
                                    [ID] = @ID";

            comandoSelecao.CommandText = sqlSelecao;
            comandoSelecao.Parameters.AddWithValue("ID", tarefa.Id);
            comandoSelecao.ExecuteNonQuery();
            conexaoComBanco.Close();
        }
        public void InsertDbProvider(Tarefa tarefa)
        {
            string enderecoDBEmpresa =
              @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DbControleTarefas;Integrated Security=True;Pooling=False";

            SqlConnection conexaoComBanco = new SqlConnection();
            conexaoComBanco.ConnectionString = enderecoDBEmpresa;
            conexaoComBanco.Open();

            SqlCommand comandoSelecao = new SqlCommand();
            comandoSelecao.Connection = conexaoComBanco;

            string sqlSelecao =@"INSERT  INTO TB_TAREFAS 
                                        ([TITULO], [DATACRICACAO], [DATACONCLUCAO], [PERCENTUAL], [PRIORIDADE])
                                VALUES 
                                        (@TITULO , @DATACRICACAO , @DATACONCLUCAO,  @PERCENTUAL , @PRIORIDADE)";

            comandoSelecao.CommandText = sqlSelecao;
            comandoSelecao.Parameters.AddWithValue("PRIORIDADE", tarefa.Prioridade);
            comandoSelecao.Parameters.AddWithValue("TITULO", tarefa.Titulo);
            comandoSelecao.Parameters.AddWithValue("DATACRICACAO", tarefa.DataCriacao);
            comandoSelecao.Parameters.AddWithValue("DATACONCLUCAO", tarefa.DataConclusao);
            comandoSelecao.Parameters.AddWithValue("PERCENTUAL", tarefa.Percentual);

            comandoSelecao.ExecuteNonQuery();
            conexaoComBanco.Close();
        }

        public DataTable SelectDbProviderPercentual( bool tipoDeBusca)
        {

            string enderecoDBEmpresa =
              @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DbControleTarefas;Integrated Security=True;Pooling=False";

            SqlConnection conexaoComBanco = new SqlConnection();
            conexaoComBanco.ConnectionString = enderecoDBEmpresa;
            conexaoComBanco.Open();

            SqlCommand comandoSelecao = new SqlCommand();
            comandoSelecao.Connection = conexaoComBanco;
            string sqlSelecao = "";
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
            comandoSelecao.CommandText = sqlSelecao;

            var sdr = comandoSelecao.ExecuteReader();
            DataTable linhas = new DataTable();
            linhas.Load(sdr);
            conexaoComBanco.Close();
            return linhas;
        }

        public DataTable SelectDbProvider(Tarefa tarefa)
        {
            string enderecoDBEmpresa =
              @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DbControleTarefas;Integrated Security=True;Pooling=False";

            SqlConnection conexaoComBanco = new SqlConnection();
            conexaoComBanco.ConnectionString = enderecoDBEmpresa;
            conexaoComBanco.Open();

            SqlCommand comandoSelecao = new SqlCommand();
            comandoSelecao.Connection = conexaoComBanco;

            string sqlSelecao =
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
                        PRIORIDADE LIKE @PRIORIDADE";

            comandoSelecao.CommandText = sqlSelecao;
            comandoSelecao.Parameters.AddWithValue("PRIORIDADE", tarefa.Prioridade);

            var sdr = comandoSelecao.ExecuteReader();
            DataTable linhas = new DataTable();
            linhas.Load(sdr);
            conexaoComBanco.Close();
            return linhas;
        }
        public TarefaDAO()
        {

        }
    }
}
