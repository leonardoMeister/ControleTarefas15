﻿using System;
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
        private string VerificarCampos()
        {
            if (textBoxTitulo.Text == "") return "Titulo Vazio";
            if (comboBoxPrioridade.SelectedItem == null) return "Nenhuma Prioridade Selecionada";
            if (comboBoxPercentual.SelectedItem == null) return "Nenhum Percentual Selecionado";
            if (dateConclucao.Text == dateCriacao.Text) return "Datas Não Podem Ser Iguais";
            return "Valido";
        }
        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos() == "Valido")
            {
                ColetarDadosTarefaECriarObjeto();
                daoTarefa.EditarDbProvider(tarefa);
                this.Close();
            }
        }

        private void Btn_remover_Click(object sender, EventArgs e)
        {
            if (VerificarCampos() == "Valido")
            {
                ColetarDadosTarefaECriarObjeto();
                daoTarefa.RemoverDbProvider(tarefa);
                this.Close();
            }
        }

        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos() == "Valido")
            {
                ColetarDadosTarefaECriarObjeto();
                daoTarefa.InsertDbProvider(tarefa);
                this.Close();
            }
            else MessageBox.Show(VerificarCampos());
        }

        private void ColetarDadosTarefaECriarObjeto()
        {
            tarefa = new Tarefa
            {
                DataConclusao = dateConclucao.Value,
                DataCriacao = dateCriacao.Value,
                Id = Convert.ToInt32( mk_id.Text),
                Percentual = comboBoxPercentual.SelectedItem.ToString(),
                Prioridade = comboBoxPrioridade.SelectedItem.ToString(),
                Titulo = textBoxTitulo.Text
            };
        }
    }
}
