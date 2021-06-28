using ControleDao.DAO.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ControleTarefasTestes
{
    [TestClass]
    public class CompromissoTeste
    {
        [TestMethod]
        public void DeverRetornarDatasIguais()
        {
            Compromisso compromisso = new Compromisso
            {
                Data = new DateTime(2021,06,23),
                DataTermino = new DateTime(2021, 06, 23),
            };

            string auxValidacao = "";
            auxValidacao += compromisso.ValidarCampos();

            Assert.AreEqual(auxValidacao, "Datas Iguais\n");
        }

        [TestMethod]
        public void DeverRetornarAssuntoVazio()
        {
            Compromisso compromisso = new Compromisso
            {
                Data = DateTime.Now,
                DataTermino = DateTime.Now.AddDays(1),
                Assunto = "",
            };

            string auxValidacao = "";
            auxValidacao += compromisso.ValidarCampos();

            Assert.AreEqual(auxValidacao, "Assunto Vazio\n");
        }
        [TestMethod]
        public void DeverRetornarLocal()
        {
            Compromisso compromisso = new Compromisso
            {
                Data = DateTime.Now,
                DataTermino = DateTime.Now.AddDays(1),
                Assunto = "Nada",
                Local = "",
            };

            string auxValidacao = "";
            auxValidacao += compromisso.ValidarCampos();

            Assert.AreEqual(auxValidacao, "Local Vazio\n");
        }
        [TestMethod]
        public void DeverRetornarLinkDeveSerVazio()
        {
            Compromisso compromisso = new Compromisso
            {
                Data = DateTime.Now,
                DataTermino = DateTime.Now.AddDays(1),
                Assunto = "Nada",
                Local = "Nada",
                Tipo = 1,
                Link = "Link do Meet",
            };

            string auxValidacao = "";
            auxValidacao += compromisso.ValidarCampos();

            Assert.AreEqual(auxValidacao, "Link Deve Ser Vazio Para Presencial\n");
        }
        [TestMethod]
        public void DeverRetornarLinkNaoDeveSerVazio()
        {
            Compromisso compromisso = new Compromisso
            {
                Data = DateTime.Now,
                DataTermino = DateTime.Now.AddDays(1),
                Assunto = "Nada",
                Local = "Nada",
                Tipo = 2,
                Link = "",
            };

            string auxValidacao = "";
            auxValidacao += compromisso.ValidarCampos();

            Assert.AreEqual(auxValidacao, "Link Vazio\n");
        }
        [TestMethod]
        public void DeverRetornarNaoPodeMarcarNadaFimSemana()
        {
            Compromisso compromisso = new Compromisso
            {
                Data = new DateTime(2021,06,27),
                DataTermino = DateTime.Now.AddDays(1),
                Assunto = "Nada",
                Local = "Nada",
                Tipo = 2,
                Link = "Link Do Meet",
            };

            string auxValidacao = "";
            auxValidacao += compromisso.ValidarCampos();

            Assert.AreEqual(auxValidacao, "Não Pode Marcar Nada Nos Fins De Semana\n");
        }

        [TestMethod]
        public void DeverRetornarDataTerminoNaoPodeSerAntesInicio()
        {
            Compromisso compromisso = new Compromisso
            {
                Data = new DateTime(2021, 06, 23),
                DataTermino = new DateTime(2021, 06, 22),
                Assunto = "Nada",
                Local = "Nada",
                Tipo = 2,
                Link = "Link Do Meet",
            };

            string auxValidacao = "";
            auxValidacao += compromisso.ValidarCampos();

            Assert.AreEqual(auxValidacao, "Data Termino Não Pode Ser Antes Do Inicio.\n");
        }
    }
}
