using System;

namespace ControleDao.DAO
{
    public class Tarefa : DominioBase
    {
        public DateTime DataCriacao { get; set; }
        public string Prioridade { get; set; }
        public DateTime DataConclusao { get; set; }
        public string Titulo { get; set; }
        public string Percentual { get; set; }

        public string ValidarCampos()
        {
            string auxValido = "";
            if (Titulo == "") auxValido += "Titulo Vazio\n";
            if (Prioridade == "") auxValido += "Nenhuma Prioridade Selecionada\n";
            if (Percentual == "") auxValido += "Nenhum Percentual Selecionado\n";
            if (DataConclusao.Date == DataCriacao.Date) auxValido += "Datas Não Podem Ser Iguais";

            if (auxValido == "")
            {
                return "Valido";
            }
            else return auxValido;
        }
    }
}