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
    public partial class FormTarefa : Form
    {
        Tarefa tarefa;
        private TarefaDAO daoTarefa;
        public FormTarefa()
        {
            InitializeComponent();
            Eventos();
            userControlBTN.btn_remover.Enabled = false;
            userControlBTN.btn_salvar.Enabled = false;
        }

        public FormTarefa(Tarefa tarefa)
        {
            InitializeComponent();
            Eventos();
            dateCriacao.Enabled = false;
            userControlBTN.btn_adicionar.Enabled = false;
            PreencherCampos(tarefa);
        }

        private void Eventos()
        {
            userControlBTN.btn_adicionar.Click += Btn_adicionar_Click;
            userControlBTN.btn_remover.Click += Btn_remover_Click;
            userControlBTN.btn_salvar.Click += Btn_salvar_Click;
            mk_id.Text = "0";
            daoTarefa = new TarefaDAO();
        }

        private void PreencherCampos(Tarefa tarefa)
        {
            mk_id.Text = Convert.ToString( tarefa.Id);
            dateCriacao.Value = tarefa.DataCriacao;
            dateConclucao.Value = tarefa.DataConclusao;
            textBoxTitulo.Text = tarefa.Titulo;
            foreach (string itens in comboBoxPrioridade.Items)
            {
                if (itens == tarefa.Prioridade) comboBoxPrioridade.SelectedItem = itens;
            }
            foreach (string itens in comboBoxPercentual.Items)
            {
                if (itens == tarefa.Percentual) comboBoxPercentual.SelectedItem = itens;
            }
            if (comboBoxPercentual.SelectedItem.ToString() == "100%")
            {
                comboBoxPercentual.Enabled = false;
            }
        }

        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            if (ValizacoesPreenchimentoOBJ())
            {
                daoTarefa.SaveDbProvider(tarefa);
                this.Close();
            }
        }

        private void Btn_remover_Click(object sender, EventArgs e)
        {
            if (ValizacoesPreenchimentoOBJ())
            {
                daoTarefa.RemoverDbProvider(tarefa);
                this.Close();
            }
        }

        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            if (ValizacoesPreenchimentoOBJ())
            {
                daoTarefa.InsertDbProvider(tarefa);
                this.Close();
            }
        }

        private bool ValizacoesPreenchimentoOBJ()
        {
            string auxValidar = ColetarDadosTarefaECriarObjeto();
            if (auxValidar == "") auxValidar += tarefa.ValidarCampos();

            if (auxValidar == "Valido")
            {
                return true;
            }
            else MessageBox.Show(auxValidar);
            return false;
        }
        private string ColetarDadosTarefaECriarObjeto()
        {
            string auxValidar = ValidarComboBoxNull();
            if (auxValidar == "")
            {
                tarefa = new Tarefa
                {
                    DataConclusao = dateConclucao.Value,
                    DataCriacao = dateCriacao.Value,
                    Id = Convert.ToInt32(mk_id.Text),
                    Percentual = comboBoxPercentual.SelectedItem.ToString(),
                    Prioridade = comboBoxPrioridade.SelectedItem.ToString(),
                    Titulo = textBoxTitulo.Text
                };
                return "";
            }
            else return auxValidar;
        }
        private string ValidarComboBoxNull()
        {
            string auxValidar = "";
            if (comboBoxPercentual.SelectedItem == null) auxValidar += "Selecione Um Percentual.";
            if (comboBoxPrioridade.SelectedItem == null) auxValidar += "Selecione Uma Prioridade.";
            if (auxValidar == "") return "";
            return auxValidar;
        }
    }
}
