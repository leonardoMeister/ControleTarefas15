using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ControleDao.DAO.Dominio;
using ControleDao.DAO.DominioDAO;
namespace ControleDao.DAO.DominioDAO
{
    public class CompromissoDAO : GenericsDAO
    {
        Compromisso Compromisso;

        public CompromissoDAO()
        {
            enderecoDBEmpresa = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DbControleTarefas;Integrated Security=True;Pooling=False";
        }

        public DataTable SelectEbProviderPorCargo(string filtro)
        {
            string auxFiltro = "%" + filtro + "%";
            string sqlSelecao = $@"SELECT [ID_COMPROMISSO], [ASSUNTO], [CONTATO_ID], [DATA_COMPROMISSO] , [DATA_TERMINO], [local_compromisso],[TIPO_COMPROMISSO],[LINK_COMPROMISSO] FROM TB_COMPROMISSO WHERE CARGO LIKE  '{auxFiltro}' ";

            return DbExecuteReader(sqlSelecao);
        }

        #region REGIÃO DE COMANDOS SQL PADRÃO
        public void RemoverDbProvider(Compromisso compromisso)
        {
            string sqlSelecao = @"DELETE FROM TB_COMPROMISSO                               
                                WHERE 
                                    [ID_COMPROMISSO] = @ID_COMPROMISSO";
            this.Compromisso = compromisso;
            DbExecuteNonQuery(sqlSelecao);
        }

        public void SaveDbProvider(Compromisso compromisso)
        {
            string sqlSelecao = @"UPDATE TB_COMPROMISSO 
                                SET [ASSUNTO] = @ASSUNTO, [CONTATO_ID] = @CONTATO_ID , 
                                    [DATA_COMPROMISSO] = @DATA_COMPROMISSO , [DATA_TERMINO] = @DATA_TERMINO ,
                                    [LINK_COMPROMISSO] = @LINK_COMPROMISSO, [local_compromisso]= @local_compromisso  , [TIPO_COMPROMISSO] = @TIPO_COMPROMISSO
                                WHERE 
                                    [ID_COMPROMISSO] = @ID_COMPROMISSO";
            this.Compromisso = compromisso;
            DbExecuteNonQuery(sqlSelecao);
        }

        public DataTable SelectDbProvider()
        {
            string sqlSelecao = $@"SELECT [ID_COMPROMISSO], [ASSUNTO], [CONTATO_ID], [DATA_COMPROMISSO] , [DATA_TERMINO], [local_compromisso],[TIPO_COMPROMISSO],[LINK_COMPROMISSO] FROM TB_COMPROMISSO";
            return DbExecuteReader(sqlSelecao);
        }

        public void InsertDbProvider(Compromisso compromisso)
        {
            string sqlSelecao = @"INSERT  INTO TB_COMPROMISSO 
                                        ([ASSUNTO], [CONTATO_ID], [DATA_COMPROMISSO], [DATA_TERMINO], [LINK_COMPROMISSO], [LOCAL_COMPROMISSO] , [TIPO_COMPROMISSO])
                                VALUES                                                                                                        
                                        (@ASSUNTO , @CONTATO_ID , @DATA_COMPROMISSO,  @DATA_TERMINO , @LINK_COMPROMISSO, @local_compromisso , @TIPO_COMPROMISSO )";
            this.Compromisso = compromisso;
            DbExecuteNonQuery(sqlSelecao);
        }
        #endregion

        protected override void GerarParametrosInserir(SqlCommand comandoSelecao)
        {
            comandoSelecao.Parameters.AddWithValue("ID_COMPROMISSO", Compromisso.Id);
            comandoSelecao.Parameters.AddWithValue("ASSUNTO", Compromisso.Assunto);
            comandoSelecao.Parameters.AddWithValue("CONTATO_ID", Compromisso.ContatoId);
            comandoSelecao.Parameters.AddWithValue("DATA_COMPROMISSO", Compromisso.Data);
            comandoSelecao.Parameters.AddWithValue("DATA_TERMINO", Compromisso.DataTermino);
            comandoSelecao.Parameters.AddWithValue("LINK_COMPROMISSO", Compromisso.Link);
            comandoSelecao.Parameters.AddWithValue("local_compromisso", Compromisso.Local);
            comandoSelecao.Parameters.AddWithValue("TIPO_COMPROMISSO", Compromisso.Tipo);
        }
    }
}