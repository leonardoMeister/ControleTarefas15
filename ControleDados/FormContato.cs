using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleDao.DAO;
using System.Windows.Forms;

namespace ControleTarefas15
{
    public partial class FormContato : Form
    {
        Contato contato;
        ContatosDAO daoContato;
        public FormContato()
        {
            InitializeComponent();
            Eventos();
            userControlBTN.btn_remover.Enabled = false;
            userControlBTN.btn_salvar.Enabled = false;
        }
        public FormContato(Contato contatoAux)
        {
            InitializeComponent();
            Eventos();
            AtualizarTela(contatoAux);
            userControlBTN.btn_adicionar.Enabled = false;
        }
        private void Eventos()
        {
            userControlBTN.btn_adicionar.Click += Btn_adicionar_Click;
            userControlBTN.btn_remover.Click += Btn_remover_Click;
            userControlBTN.btn_salvar.Click += Btn_salvar_Click;
            mk_id.Text = "0";
            daoContato = new ContatosDAO();
        }

        private void AtualizarTela(Contato contato)
        {
            mk_id.Text = Convert.ToString(contato.Id);
            textBoxCargo.Text = contato.Cargo;
            textBoxEmail.Text = contato.Email;
            textBoxEmpresa.Text = contato.Empresa;
            textBoxNome.Text = contato.Nome;
            mk_telefone.Text = contato.Telefone;
        }

        private string ValidarCampos()
        {
            if (textBoxNome.Text == "") return "Campo Nome Vazio";
            if (textBoxEmpresa.Text == "") return "Campo Empresa Vazio";
            if (textBoxEmail.Text == "") return "Campo Email Vazio";
            if (textBoxCargo.Text == "") return "Campo Cargo Vazio";
            if (mk_telefone.Text == "") return "Campo Telefone Vazio";
            if (!ValidarEmail()) return "Email Invalido!";
            if (mk_telefone.Text.Length <= 9) return "Telefone Invalido!";

            return "Valido";
        }

        private void CriarContatoComDadosTela()
        {
            contato = new Contato
            {
                Cargo = textBoxCargo.Text,
                Email = textBoxEmail.Text,
                Empresa = textBoxEmpresa.Text,
                Nome = textBoxNome.Text,
                Id = Convert.ToInt32(mk_id.Text),
                Telefone = mk_telefone.Text
            };
        }

        private bool ValidarEmail()
        {
            bool arroba = false, ponto = false;
            foreach (char letra in textBoxEmail.Text)
            {
                if (letra == '@') arroba = true;
                if (letra == '.') ponto = true;
            }
            if (arroba && ponto) return true;
            return false;
        }

        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == "Valido")
            {
                CriarContatoComDadosTela();
                daoContato.SaveDbProvider(contato);
                this.Close();
            }
        }

        private void Btn_remover_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == "Valido")
            {
                CriarContatoComDadosTela();
                daoContato.RemoverDbProvider(contato);
                this.Close();
            }
        }

        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == "Valido")
            {
                CriarContatoComDadosTela();
                daoContato.InsertDbProvider(contato);
                this.Close();
            }
            else MessageBox.Show(ValidarCampos());
        }
    }
}
