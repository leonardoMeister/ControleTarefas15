using System;
using System.Data;
using ControleDao.DAO;
using System.Windows.Forms;

namespace ControleTarefas15
{
    public partial class FormMenuTarefa : Form
    {
        FormTarefa formtarefa;
        Tarefa tarefa;
        private readonly TarefaDAO daoTarefa;
        public FormMenuTarefa()
        {
            InitializeComponent();
            daoTarefa = new TarefaDAO();
        }

        private void btn_AdicionarTarefa_Click(object sender, EventArgs e)
        {
            formtarefa = new FormTarefa();
            formtarefa.ShowDialog();
            dataGridDados.Columns.Clear();
        }

        private void btn_prioridadeUm_Click(object sender, EventArgs e)
        {
            BuscaPorPrioridade("Um");
        }
        private void btn_prioridadeDois_Click(object sender, EventArgs e)
        {
            BuscaPorPrioridade("Dois");
        }
        private void btn_prioridadeTres_Click(object sender, EventArgs e)
        {
            BuscaPorPrioridade("Tres");
        }
        private void btn_concluidas_Click(object sender, EventArgs e)
        {
            BuscaPorPendencia(true);
        }

        private void btn_emAberto_Click(object sender, EventArgs e)
        {
            BuscaPorPendencia(false);
        }

        private void BuscaPorPrioridade(string busca)
        {
            tarefa = new Tarefa
            {
                Prioridade = busca,
                DataConclusao = DateTime.Now,
                DataCriacao = DateTime.Now,
                Id = 0,
                Percentual = "",
                Titulo = ""
            };
            DataTable tb = daoTarefa.SelectDbProvider(tarefa);
            AtualizarGrid(tb);

        }
        private void BuscaPorPendencia(bool tipoDeBusca)
        {
            DataTable tb = daoTarefa.SelectDbProviderPercentual(tipoDeBusca);
            AtualizarGrid(tb);
        }

        private void AtualizarGrid(DataTable tb)
        {
            dataGridDados.Columns.Clear();
            dataGridDados.AutoGenerateColumns = true;
            if (tb.Rows.Count == 0)
            {
                MessageBox.Show("Busca Sem Valores");
            }
            dataGridDados.DataSource = tb;
            dataGridDados.Refresh();
        }

        private void dataGridDados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridDados.SelectedCells.Count > 0)
            {
                tarefa = new Tarefa
                {
                    Id = Convert.ToInt32(dataGridDados.SelectedCells[0].Value.ToString()),
                    Titulo = dataGridDados.SelectedCells[1].Value.ToString(),
                    DataCriacao = Convert.ToDateTime(dataGridDados.SelectedCells[2].Value.ToString()),
                    DataConclusao = Convert.ToDateTime(dataGridDados.SelectedCells[3].Value.ToString()),
                    Percentual = dataGridDados.SelectedCells[4].Value.ToString(),
                    Prioridade = dataGridDados.SelectedCells[5].Value.ToString(),
                };
                formtarefa = new FormTarefa(tarefa);
                formtarefa.ShowDialog();

                dataGridDados.Columns.Clear();
            }
        }

    }
}