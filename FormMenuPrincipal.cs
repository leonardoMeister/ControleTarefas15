using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
