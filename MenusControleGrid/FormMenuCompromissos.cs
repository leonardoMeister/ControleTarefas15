using System;
using System.Windows.Forms;
using ControleDao.DAO;
using ControleTarefas15.ControleDados;
using System.Data;
using ControleDao.DAO.Dominio;
using ControleDao.DAO.DominioDAO;

namespace ControleTarefas15.MenusControleGrid
{
    public partial class FormMenuCompromissos : Form
    {
        private readonly CompromissoDAO daoCompromisso;
        public FormMenuCompromissos()
        {
            InitializeComponent();
            daoCompromisso = new CompromissoDAO();
            AtualizarGrid(daoCompromisso.SelectDbProvider());
        }

        private void btn_compromisso_Click(object sender, EventArgs e)
        {
            FormCompromissos formCompromissos = new FormCompromissos();
            formCompromissos.ShowDialog();
        }

        private void dataGridDados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridDados.SelectedCells.Count > 0)
            {
                Compromisso compromisso = new Compromisso
                {
                    Id = Convert.ToInt32(dataGridDados.SelectedCells[0].Value.ToString()),
                    Assunto = dataGridDados.SelectedCells[1].Value.ToString(),
                    ContatoId = Convert.ToInt32(dataGridDados.SelectedCells[2].Value.ToString()),
                    Data = Convert.ToDateTime( dataGridDados.SelectedCells[3].Value.ToString()),
                    DataTermino = Convert.ToDateTime(dataGridDados.SelectedCells[4].Value.ToString()),
                    Local = dataGridDados.SelectedCells[5].Value.ToString(),
                    Tipo = Convert.ToInt32( dataGridDados.SelectedCells[6].Value.ToString()),
                    Link = dataGridDados.SelectedCells[7].Value.ToString(),
                };
                FormCompromissos formCompromissos = new FormCompromissos(compromisso);
                formCompromissos.ShowDialog();
                dataGridDados.Columns.Clear();
                DataTable tb = daoCompromisso.SelectDbProvider();
                AtualizarGrid(tb);
            }
        }

        private void btn_dataDefinida_Click(object sender, EventArgs e)
        {
            DateTime data = dataDefinida.Value;
        }

        private void btn_semana_Click(object sender, EventArgs e)
        {

        }

        private void btn_hoje_Click(object sender, EventArgs e)
        {

        }

        private void AtualizarGrid(DataTable table)
        {
            dataGridDados.Columns.Clear();
            dataGridDados.AutoGenerateColumns = true;
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Busca Sem Valores");
            }
            dataGridDados.DataSource = table;
            dataGridDados.Refresh();
        }
    }
}
