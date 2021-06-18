using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDao.DAO
{
    public class Contato
    {
        public int Id { get; set; }
        public string Cargo { get; set; }
        public string Email { get; set; }
        public string Empresa { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
    public class ContatosDAO
    {
        public void RemoverDbProvider(Contato contato)
        {
            string enderecoDBEmpresa =
                          @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DbControleTarefas;Integrated Security=True;Pooling=False";

            SqlConnection conexaoComBanco = new SqlConnection();
            conexaoComBanco.ConnectionString = enderecoDBEmpresa;
            conexaoComBanco.Open();

            SqlCommand comandoSelecao = new SqlCommand();
            comandoSelecao.Connection = conexaoComBanco;

            string sqlSelecao = @"DELETE FROM TB_CONTATOS                               
                                WHERE 
                                    [ID] = @ID";

            comandoSelecao.CommandText = sqlSelecao;
            comandoSelecao.Parameters.AddWithValue("ID", contato.Id);
            comandoSelecao.ExecuteNonQuery();
            conexaoComBanco.Close();
        }

        public void SaveDbProvider(Contato contato)
        {
            string enderecoDBEmpresa =
                         @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DbControleTarefas;Integrated Security=True;Pooling=False";

            SqlConnection conexaoComBanco = new SqlConnection();
            conexaoComBanco.ConnectionString = enderecoDBEmpresa;
            conexaoComBanco.Open();

            SqlCommand comandoSelecao = new SqlCommand();
            comandoSelecao.Connection = conexaoComBanco;

            string sqlSelecao = @"UPDATE TB_CONTATOS 
                                SET [NOME] = @NOME, [EMAIL] = @EMAIL , 
                                    [TELEFONE] = @TELEFONE , [EMPRESA] = @EMPRESA ,
                                    [CARGO] = @CARGO
                                WHERE 
                                    [ID] = @ID";

            comandoSelecao.CommandText = sqlSelecao;
            comandoSelecao.Parameters.AddWithValue("ID", contato.Id);
            comandoSelecao.Parameters.AddWithValue("NOME", contato.Nome);
            comandoSelecao.Parameters.AddWithValue("EMAIL", contato.Email);
            comandoSelecao.Parameters.AddWithValue("TELEFONE", contato.Telefone);
            comandoSelecao.Parameters.AddWithValue("EMPRESA", contato.Empresa);
            comandoSelecao.Parameters.AddWithValue("CARGO", contato.Cargo);

            comandoSelecao.ExecuteNonQuery();
            conexaoComBanco.Close();
        }

        public DataTable SelectEbProviderPorCargo(string filtro)
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
                        [NOME], 
                        [EMAIL], 
                        [TELEFONE] ,
                        [EMPRESA],
                        [CARGO]
                    FROM 
                        TB_CONTATOS
                    WHERE
                        CARGO LIKE  @FILTRO ";

            comandoSelecao.CommandText = sqlSelecao;
            comandoSelecao.Parameters.AddWithValue("FILTRO", "%"+filtro+"%");

            var sdr = comandoSelecao.ExecuteReader();
            DataTable linhas = new DataTable();
            linhas.Load(sdr);
            conexaoComBanco.Close();
            return linhas;
        }

        public DataTable SelectEbProvider()
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
                        [NOME], 
                        [EMAIL], 
                        [TELEFONE] ,
                        [EMPRESA],
                        [CARGO]
                    FROM 
                        TB_CONTATOS";

            comandoSelecao.CommandText = sqlSelecao;

            var sdr = comandoSelecao.ExecuteReader();
            DataTable linhas = new DataTable();
            linhas.Load(sdr);
            conexaoComBanco.Close();
            return linhas;
        }

        public void InsertDbProvider(Contato contato)
        {
            string enderecoDBEmpresa =
                          @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DbControleTarefas;Integrated Security=True;Pooling=False";

            SqlConnection conexaoComBanco = new SqlConnection();
            conexaoComBanco.ConnectionString = enderecoDBEmpresa;
            conexaoComBanco.Open();

            SqlCommand comandoSelecao = new SqlCommand();
            comandoSelecao.Connection = conexaoComBanco;

            string sqlSelecao = @"INSERT  INTO TB_CONTATOS 
                                        ([NOME], [EMAIL], [TELEFONE], [EMPRESA], [CARGO])
                                VALUES 
                                        (@NOME , @EMAIL , @TELEFONE,  @EMPRESA , @CARGO)";

            comandoSelecao.CommandText = sqlSelecao;
            comandoSelecao.Parameters.AddWithValue("CARGO", contato.Cargo);
            comandoSelecao.Parameters.AddWithValue("NOME", contato.Nome);
            comandoSelecao.Parameters.AddWithValue("EMAIL", contato.Email);
            comandoSelecao.Parameters.AddWithValue("TELEFONE", contato.Telefone);
            comandoSelecao.Parameters.AddWithValue("EMPRESA", contato.Empresa);

            comandoSelecao.ExecuteNonQuery();
            conexaoComBanco.Close();
        }
    }
}
