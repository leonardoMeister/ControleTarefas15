using System;
using System.Data;
using ControleDao.DAO.Dominio;
using ControleDao.DAO.DominioDAO;
using ControleDao.DAO;
using System.Windows.Forms;

namespace ControleTarefas15.ControleDados
{
    public partial class FormCompromissos : Form
    {
        private CompromissoDAO daoCompromisso;
        private Compromisso compromisso;
        private ContatosDAO daoContatos;
        public FormCompromissos()
        {
            InitializeComponent();
            EventosCarregamentoTela();
            userControlBTN.btn_remover.Enabled = false;
            userControlBTN.btn_salvar.Enabled = false;
        }
        public FormCompromissos(Compromisso compromisso)
        {
            InitializeComponent();
            EventosCarregamentoTela();
            AtualizarTela(compromisso);
            userControlBTN.btn_adicionar.Enabled = false;
        }

        private void AtualizarTela(Compromisso compromisso)
        {
            textBoxAssunto.Text = compromisso.Assunto;
            textBoxLink.Text = compromisso.Link;
            mk_id.Text = Convert.ToString( compromisso.Id);
            textBoxLocal.Text = compromisso.Local;
            foreach (Contato auxContato in comboBoxContato.Items)
            {
                if (auxContato.Id == compromisso.ContatoId) comboBoxContato.SelectedItem= auxContato;
            }
            comboBoxTipo.SelectedIndex = (compromisso.Tipo == 1) ? 0 : 1;
            dataComeco.Value = compromisso.Data;
            horaComeco.Value = compromisso.Data;
            horaFinal.Value = compromisso.DataTermino;

        }
        private string ValidarCampos()
        {
            string auxValidacao = "";
            auxValidacao += ValidarComboBox();
            if (auxValidacao == "") PegarObjetoTela();
            else return auxValidacao;
            auxValidacao += compromisso.ValidarCampos();
            return auxValidacao;

        }
        private string ValidarComboBox()
        {
            string auxValidacao = "";
            auxValidacao += (comboBoxTipo.SelectedItem == null) ? "Selecione Um Tipo\n" : "";
            auxValidacao += (comboBoxContato.SelectedItem == null) ? "Selecione Um Contato" : "";
            return auxValidacao;
        }

        private void PegarObjetoTela()
        {
            int tipo = (comboBoxTipo.Text == "Presencial") ? 1 : 2;

            DateTime dataInicio = new DateTime(dataComeco.Value.Year, dataComeco.Value.Month, dataComeco.Value.Day, horaComeco.Value.Hour, horaComeco.Value.Minute, horaComeco.Value.Second);
            DateTime dataTermino = new DateTime(dataComeco.Value.Year, dataComeco.Value.Month, dataComeco.Value.Day, horaFinal.Value.Hour, horaFinal.Value.Minute, horaFinal.Value.Second);

            compromisso = new Compromisso
            {
                Id = Convert.ToInt32(mk_id.Text),
                Assunto = textBoxAssunto.Text,
                ContatoId = ((Contato)comboBoxContato.SelectedItem).Id,
                Link = textBoxLink.Text,
                Local = textBoxLocal.Text,
                Tipo = tipo,
                Data = dataInicio,
                DataTermino = dataTermino,
            };
        }

        private void EventosCarregamentoTela()
        {
            userControlBTN.btn_remover.Click += Btn_remover_Click;
            userControlBTN.btn_salvar.Click += Btn_salvar_Click;
            userControlBTN.btn_adicionar.Click += Btn_adicionar_Click;
            mk_id.Text = "0";
            daoCompromisso = new CompromissoDAO();
            daoContatos = new ContatosDAO();
            CarregarContatos();
        }

        private void CarregarContatos()
        {
            comboBoxContato.Items.Clear();
            DataTable tabela = daoContatos.SelectDbProvider();
            foreach (DataRow row in tabela.Rows)
            {
                Contato contato = new Contato
                {
                    Id = Convert.ToInt32(row[0].ToString()),
                    Nome = row[1].ToString(),
                    Email = row[2].ToString(),
                    Telefone = row[3].ToString(),
                    Empresa = row[4].ToString(),
                    Cargo = row[5].ToString()
                };
                comboBoxContato.Items.Add(contato);
            }
        }

        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            string auxValidacao = "";
            auxValidacao += ValidarCampos();
            if (auxValidacao == "Valido")
            {
                daoCompromisso.InsertDbProvider(compromisso);
                this.Close();
            }
            else MessageBox.Show(auxValidacao);
        }

        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            string auxValidacao = "";
            auxValidacao += ValidarCampos();
            if (auxValidacao == "Valido")
            {
                daoCompromisso.SaveDbProvider(compromisso);
                this.Close();
            }
            else MessageBox.Show(auxValidacao);
        }

        private void Btn_remover_Click(object sender, EventArgs e)
        {
            string auxValidacao = "";
            auxValidacao += ValidarCampos();
            if (auxValidacao == "Valido")
            {
                daoCompromisso.RemoverDbProvider(compromisso);
                this.Close();
            }
            else MessageBox.Show(auxValidacao);
        }
    }
}
