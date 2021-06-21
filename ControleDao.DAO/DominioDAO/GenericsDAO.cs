using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDao.DAO
{
    public abstract class GenericsDAO
    {
        protected string enderecoDBEmpresa;

        public void DbExecuteNonQuery(string sqlSelecao)
        {
            SqlConnection conexaoComBanco = new SqlConnection();
            conexaoComBanco.ConnectionString = enderecoDBEmpresa;
            conexaoComBanco.Open();

            SqlCommand comandoSelecao = new SqlCommand();
            comandoSelecao.Connection = conexaoComBanco;

            comandoSelecao.CommandText = sqlSelecao;
            GerarParametrosInserir(comandoSelecao);

            comandoSelecao.ExecuteNonQuery();
            conexaoComBanco.Close();
        }

        protected abstract void GerarParametrosInserir(SqlCommand comandoSelecao);      

        public DataTable DbExecuteReader(string sqlSelecao)
        {
            SqlConnection conexaoComBanco = new SqlConnection();
            conexaoComBanco.ConnectionString = enderecoDBEmpresa;
            conexaoComBanco.Open();

            SqlCommand comandoSelecao = new SqlCommand();
            comandoSelecao.Connection = conexaoComBanco;             

            comandoSelecao.CommandText = sqlSelecao;

             var sdr = comandoSelecao.ExecuteReader();
            DataTable linhas = new DataTable();
            linhas.Load(sdr);
            conexaoComBanco.Close();
            return linhas;
        }

    }
}