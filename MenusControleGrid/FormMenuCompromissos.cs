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
                AtualizarGrid(daoCompromisso.SelectDbProvider());
            }
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

        #region EVENTOS DE BTN TELA

        private void btn_compromisso_Click(object sender, EventArgs e)
        {
            FormCompromissos formCompromissos = new FormCompromissos();
            formCompromissos.ShowDialog();

            dataGridDados.Columns.Clear();
            AtualizarGrid(daoCompromisso.SelectDbProvider());
        }

        private void btn_dataDefinida_Click(object sender, EventArgs e)
        {
            DateTime dataPegadoDaTela = new DateTime(dataDefinida.Value.Year, dataDefinida.Value.Month, dataDefinida.Value.Day, 23, 59, 59);
            AtualizarGrid(daoCompromisso.SelectDbProviderPorData(dataPegadoDaTela));
        }

        private void btn_semana_Click(object sender, EventArgs e)
        {
            DateTime dataParaLerSemana = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59).AddDays(7);
            AtualizarGrid(daoCompromisso.SelectDbProviderPorData(dataParaLerSemana));
        }

        private void btn_hoje_Click(object sender, EventArgs e)
        {
            DateTime dataParaLerDia = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            AtualizarGrid(daoCompromisso.SelectDbProviderPorData(dataParaLerDia));
        }

        private void btn_passado_Click(object sender, EventArgs e)
        {
            AtualizarGrid(daoCompromisso.SelectDbProviderPassadoDataAtual());
        }

        private void btn_futuro_Click(object sender, EventArgs e)
        {
            AtualizarGrid(daoCompromisso.SelectDbProviderFuturoDataAtual());
        }

        private void btn_todosDados_Click(object sender, EventArgs e)
        {
            AtualizarGrid(daoCompromisso.SelectDbProvider());
        }

        #endregion

    }
}
