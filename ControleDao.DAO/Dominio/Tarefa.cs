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
    }
}