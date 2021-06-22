using System;
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

        private void CriarContatoComDadosTela()
        {
            contato = GerarContato();
        }
        public Contato GerarContato()
        {
            Contato x = new Contato
            {
                Cargo = textBoxCargo.Text,
                Email = textBoxEmail.Text,
                Empresa = textBoxEmpresa.Text,
                Nome = textBoxNome.Text,
                Id = Convert.ToInt32(mk_id.Text),
                Telefone = mk_telefone.Text
            };
            return x;
        }

        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            CriarContatoComDadosTela();
            string auxValidacao = contato.ValidarCampos();
            if (auxValidacao == "Valido")
            {
                daoContato.SaveDbProvider(contato);
                this.Close();
            }
            else MessageBox.Show(auxValidacao);

        }

        private void Btn_remover_Click(object sender, EventArgs e)
        {
            CriarContatoComDadosTela();
            string auxValidacao = contato.ValidarCampos();
            if (auxValidacao == "Valido")
            {
                daoContato.RemoverDbProvider(contato);
                this.Close();
            }
            else MessageBox.Show(auxValidacao);
        }

        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            CriarContatoComDadosTela();
            string auxValidacao = contato.ValidarCampos();
            if (auxValidacao == "Valido")
            {
                daoContato.InsertDbProvider(contato);
                this.Close();
            }
            else MessageBox.Show(auxValidacao);
        }
    }
}