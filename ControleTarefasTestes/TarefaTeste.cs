using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControleDao.DAO;
using System;

namespace ControleTarefasTestes
{
    [TestClass]
    public class TarefaTeste
    {
        [TestMethod]
        public void DeveRetornarTarefaValida()
        {
            Tarefa tarefa = new Tarefa
            {
                Percentual = "30%",
                Prioridade = "Um",
                Titulo = "Qualquer coisa",
                Id = 0,
                DataConclusao = DateTime.Now,
                DataCriacao = new DateTime(2001,12,23)
            };
            string auxValido = tarefa.ValidarCampos();
            Assert.AreEqual(auxValido, "Valido");
        }
        [TestMethod]
        public void DeveRetornarTarefaDatasIguais()
        {
            Tarefa tarefa = new Tarefa
            {
                Percentual = "30%",
                Prioridade = "Um",
                Titulo = "Qualquer coisa",
                Id = 0,
                DataConclusao = new DateTime(2001, 12, 23),
                DataCriacao = new DateTime(2001, 12, 23)
            };
            string auxValido = tarefa.ValidarCampos();
            Assert.AreEqual(auxValido, "Datas Não Podem Ser Iguais");
        }
        [TestMethod]
        public void DeveRetornarTarefaSemPrioridade()
        {
            Tarefa tarefa = new Tarefa
            {
                Percentual = "30%",
                Prioridade = "",
                Titulo = "Qualquer coisa",
                Id = 0,
                DataConclusao = DateTime.Now,
                DataCriacao = new DateTime(2001, 12, 23)
            };
            string auxValido = tarefa.ValidarCampos();
            Assert.AreEqual(auxValido, "Nenhuma Prioridade Selecionada\n");
        }
        [TestMethod]
        public void DeveRetornarTarefaSemPercentual()
        {
            Tarefa tarefa = new Tarefa
            {
                Percentual = "",
                Prioridade = "Um",
                Titulo = "Qualquer coisa",
                Id = 0,
                DataConclusao = DateTime.Now,
                DataCriacao = new DateTime(2001, 12, 23)
            };
            string auxValido = tarefa.ValidarCampos();
            Assert.AreEqual(auxValido, "Nenhum Percentual Selecionado\n");
        }
        [TestMethod]
        public void DeveRetornarTarefaSemTitulo()
        {
            Tarefa tarefa = new Tarefa
            {
                Percentual = "10%",
                Prioridade = "Um",
                Titulo = "",
                Id = 0,
                DataConclusao = DateTime.Now,
                DataCriacao = new DateTime(2001, 12, 23)
            };
            string auxValido = tarefa.ValidarCampos();
            Assert.AreEqual(auxValido, "Titulo Vazio\n");
        }
    }
}
