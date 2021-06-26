using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDao.DAO.Dominio
{
    public class Compromisso : DominioBase
    {
        public string Assunto { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataTermino { get; set; }
        public string Local { get; set; }
        public int Tipo { get; set; }
        public string Link { get; set; }
        public int ContatoId { get; set; }

        public string ValidarCampos()
        {
            string auxValidacao = "";

            auxValidacao += (Data == DataTermino) ? "Datas Iguais\n" : "";
            auxValidacao += (Assunto == "") ? "Assunto Vazio\n" : "";
            auxValidacao += (Local == "") ? "Local Vazio\n" : "";
            auxValidacao += (Tipo == 2 && Link == "") ? "Link Vazio\n" : "";
            auxValidacao += (Data > DataTermino) ? "Data Termino Não Pode Ser Antes Do Inicio.\n" : "";
            auxValidacao += (Data.DayOfWeek.ToString() == "Saturday" || Data.DayOfWeek.ToString() == "Sunday") ?"Não Pode Marcar Nada Nos Fins De Semana\n":"";
            auxValidacao += (Tipo == 1 && Link != "") ? "Link Deve Ser Vazio Para Presencial\n" : "";
            return (auxValidacao == "") ? "Valido" : auxValidacao;
        }

    }
}
