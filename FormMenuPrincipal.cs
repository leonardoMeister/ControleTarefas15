using System;
using System.Windows.Forms;
using ControleTarefas15.MenusControleGrid;

namespace ControleTarefas15
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btn_tarefas_Click(object sender, EventArgs e)
        {
            FormMenuTarefa formMenuTarefa = new FormMenuTarefa();
            formMenuTarefa.ShowDialog();
        }

        private void btn_contatos_Click(object sender, EventArgs e)
        {
            FormMenuContato formMenuContato = new FormMenuContato();
            formMenuContato.ShowDialog();
        }

        private void btn_compromissos_Click(object sender, EventArgs e)
        {
            FormMenuCompromissos formMenuContato = new FormMenuCompromissos();
            formMenuContato.ShowDialog();
        }
    }
}
