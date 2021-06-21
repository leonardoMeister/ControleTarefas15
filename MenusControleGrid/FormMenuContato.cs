using System;
using System.Data;
using ControleDao.DAO;
using System.Windows.Forms;

namespace ControleTarefas15
{
    public partial class FormMenuContato : Form
    {
        private readonly ContatosDAO daoContato;
        public FormMenuContato()
        {
            InitializeComponent();
            daoContato = new ContatosDAO();
            DataTable tb = daoContato.SelectDbProvider();
            AtualizarDataGrid(tb);
        }

        private void btn_AdicionarTarefa_Click(object sender, EventArgs e)
        {
            FormContato formContato = new FormContato();
            formContato.ShowDialog();
            DataTable tb = daoContato.SelectDbProvider();
            AtualizarDataGrid(tb);
        }

        private void AtualizarDataGrid(DataTable tb)
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
                Contato contato = new Contato
                {
                    Id = Convert.ToInt32(dataGridDados.SelectedCells[0].Value.ToString()),
                    Nome = dataGridDados.SelectedCells[1].Value.ToString(),
                    Email = dataGridDados.SelectedCells[2].Value.ToString(),
                    Telefone = dataGridDados.SelectedCells[3].Value.ToString(),
                    Empresa = dataGridDados.SelectedCells[4].Value.ToString(),
                    Cargo = dataGridDados.SelectedCells[5].Value.ToString(),
                };
                FormContato formContato = new FormContato(contato);
                formContato.ShowDialog();
                dataGridDados.Columns.Clear();
                DataTable tb = daoContato.SelectDbProvider();
                AtualizarDataGrid(tb);
            }
        }

        private void Pesquisa_Click(object sender, EventArgs e)
        {
            DataTable tb = daoContato.SelectEbProviderPorCargo(mk_pesquisa.Text);
            AtualizarDataGrid(tb);
        }
    }
}
