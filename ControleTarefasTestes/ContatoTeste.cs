using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControleDao.DAO;

namespace ControleTarefasTestes
{
    [TestClass]
    public class ContatoTeste
    {
        [TestMethod]
        public void DeveRetornarEmpresaInvalida()
        {
            Contato contato = new Contato
            {
                Cargo = "Cargo",
                Email = "Email@gmail.com",
                Empresa = "",
                Id = 0,
                Nome = "Teste",
                Telefone = "992398644"
            };

            string auxValidacao = contato.ValidarCampos();

            Assert.AreEqual(auxValidacao , "Campo Empresa Vazio\n");          
        }

        [TestMethod]
        public void DeveRetornarEmailInvalidoPorArroba()
        {
            Contato contato = new Contato
            {
                Cargo = "Cargo",
                Email = "Emailgmail.com",
                Empresa = "asdasd",
                Id = 0,
                Nome = "Teste",
                Telefone = "992398644"
            };

            string auxValidacao = contato.ValidarCampos();

            Assert.AreEqual(auxValidacao, "Email Invalido!\n");
        }
        [TestMethod]
        public void DeveRetornarEmailInvalidoPorPonto()
        {
            Contato contato = new Contato
            {
                Cargo = "Cargo",
                Email = "Email@gmailcom",
                Empresa = "asdasd",
                Id = 0,
                Nome = "Teste",
                Telefone = "992398644"
            };

            string auxValidacao = contato.ValidarCampos();

            Assert.AreEqual(auxValidacao, "Email Invalido!\n");
        }

        [TestMethod]
        public void DeveRetornarEmailVazio()
        {
            Contato contato = new Contato
            {
                Cargo = "Cargo",
                Email = "",
                Empresa = "asdasd",
                Id = 0,
                Nome = "Teste",
                Telefone = "992398644"
            };

            string auxValidacao = contato.ValidarCampos();

            Assert.AreEqual(auxValidacao, "Campo Email Vazio\nEmail Invalido!\n");
        }
        [TestMethod]
        public void DeveRetornarCargoVazio()
        {
            Contato contato = new Contato
            {
                Cargo = "",
                Email = "Email@gmail.com",
                Empresa = "asdasd",
                Id = 0,
                Nome = "Teste",
                Telefone = "992398644"
            };

            string auxValidacao = contato.ValidarCampos();

            Assert.AreEqual(auxValidacao, "Campo Cargo Vazio\n");
        }
        [TestMethod]
        public void DeveRetornarNomeVazio()
        {
            Contato contato = new Contato
            {
                Cargo = "asdasdasd",
                Email = "Email@gmail.com",
                Empresa = "asdasd",
                Id = 0,
                Nome = "",
                Telefone = "992398644"
            };

            string auxValidacao = contato.ValidarCampos();

            Assert.AreEqual(auxValidacao, "Campo Nome Vazio\n");
        }

        [TestMethod]
        public void DeveRetornarTelefoneVazio()
        {
            Contato contato = new Contato
            {
                Cargo = "asdasdasd",
                Email = "Email@gmail.com",
                Empresa = "asdasd",
                Id = 0,
                Nome = "asdasdasd",
                Telefone = ""
            };

            string auxValidacao = contato.ValidarCampos();

            Assert.AreEqual(auxValidacao, "Campo Telefone Vazio\nTelefone Invalido!");
        }
        [TestMethod]
        public void DeveRetornarValido()
        {
            Contato contato = new Contato
            {
                Cargo = "asdasdasd",
                Email = "Email@gmail.com",
                Empresa = "asdasd",
                Id = 0,
                Nome = "asdasdasd",
                Telefone = "992398644"
            };

            string auxValidacao = contato.ValidarCampos();

            Assert.AreEqual(auxValidacao, "Valido");
        }
    }
}