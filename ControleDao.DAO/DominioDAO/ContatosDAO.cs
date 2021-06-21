using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDao.DAO
{
    public class ContatosDAO : GenericsDAO
    {
        Contato contatoDao;
        public ContatosDAO()
        {
            enderecoDBEmpresa = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DbControleTarefas;Integrated Security=True;Pooling=False";
        }
        public void RemoverDbProvider(Contato contato)
        {     
            string sqlSelecao = @"DELETE FROM TB_CONTATOS                               
                                WHERE 
                                    [ID] = @ID";
            this.contatoDao = contato;
            DbExecuteNonQuery(sqlSelecao);
        }

        public void SaveDbProvider(Contato contato)
        {          
            string sqlSelecao = @"UPDATE TB_CONTATOS 
                                SET [NOME] = @NOME, [EMAIL] = @EMAIL , 
                                    [TELEFONE] = @TELEFONE , [EMPRESA] = @EMPRESA ,
                                    [CARGO] = @CARGO
                                WHERE 
                                    [ID] = @ID";
            this.contatoDao = contato;
            DbExecuteNonQuery(sqlSelecao);
        }

        public DataTable SelectEbProviderPorCargo(string filtro)
        {
            string auxFiltro = "%" + filtro + "%";
            string sqlSelecao = $@"SELECT [ID], [NOME], [EMAIL], [TELEFONE] , [EMPRESA], [CARGO] FROM TB_CONTATOS WHERE CARGO LIKE  '{auxFiltro}' ";

            return DbExecuteReader(sqlSelecao);
        }
        public DataTable SelectDbProvider()
        {
            string sqlSelecao = $@"SELECT [ID], [NOME],  [EMAIL], [TELEFONE] ,[EMPRESA], [CARGO]  FROM  TB_CONTATOS";
            return DbExecuteReader(sqlSelecao);
        }

        public void InsertDbProvider(Contato contato)
        {
            string sqlSelecao = @"INSERT  INTO TB_CONTATOS 
                                        ([NOME], [EMAIL], [TELEFONE], [EMPRESA], [CARGO])
                                VALUES 
                                        (@NOME , @EMAIL , @TELEFONE,  @EMPRESA , @CARGO)";
            this.contatoDao = contato;
            DbExecuteNonQuery(sqlSelecao);           
        }

        protected override void GerarParametrosInserir(SqlCommand comandoSelecao)
        {
            comandoSelecao.Parameters.AddWithValue("ID", contatoDao.Id);
            comandoSelecao.Parameters.AddWithValue("CARGO", contatoDao.Cargo);
            comandoSelecao.Parameters.AddWithValue("NOME", contatoDao.Nome);
            comandoSelecao.Parameters.AddWithValue("EMAIL", contatoDao.Email);
            comandoSelecao.Parameters.AddWithValue("TELEFONE", contatoDao.Telefone);
            comandoSelecao.Parameters.AddWithValue("EMPRESA", contatoDao.Empresa);
        }
    }
}