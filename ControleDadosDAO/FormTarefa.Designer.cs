
namespace ControleTarefas15
{
    partial class FormTarefa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpTarefas = new System.Windows.Forms.GroupBox();
            this.comboBoxPercentual = new System.Windows.Forms.ComboBox();
            this.comboBoxPrioridade = new System.Windows.Forms.ComboBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.labelPrioridade = new System.Windows.Forms.Label();
            this.dateCriacao = new System.Windows.Forms.DateTimePicker();
            this.dateConclucao = new System.Windows.Forms.DateTimePicker();
            this.labelParteConcluida = new System.Windows.Forms.Label();
            this.labelConclusao = new System.Windows.Forms.Label();
            this.labelDataCriacao = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.mk_id = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.userControlBTN = new ControleTarefas15.UserControlBTN();
            this.gpTarefas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpTarefas
            // 
            this.gpTarefas.Controls.Add(this.mk_id);
            this.gpTarefas.Controls.Add(this.labelId);
            this.gpTarefas.Controls.Add(this.comboBoxPercentual);
            this.gpTarefas.Controls.Add(this.comboBoxPrioridade);
            this.gpTarefas.Controls.Add(this.textBoxTitulo);
            this.gpTarefas.Controls.Add(this.labelPrioridade);
            this.gpTarefas.Controls.Add(this.dateCriacao);
            this.gpTarefas.Controls.Add(this.dateConclucao);
            this.gpTarefas.Controls.Add(this.labelParteConcluida);
            this.gpTarefas.Controls.Add(this.labelConclusao);
            this.gpTarefas.Controls.Add(this.labelDataCriacao);
            this.gpTarefas.Controls.Add(this.labelTitulo);
            this.gpTarefas.Location = new System.Drawing.Point(39, 37);
            this.gpTarefas.Name = "gpTarefas";
            this.gpTarefas.Size = new System.Drawing.Size(525, 197);
            this.gpTarefas.TabIndex = 1;
            this.gpTarefas.TabStop = false;
            this.gpTarefas.Text = "Cadastro Tarefa";
            // 
            // comboBoxPercentual
            // 
            this.comboBoxPercentual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPercentual.FormattingEnabled = true;
            this.comboBoxPercentual.Items.AddRange(new object[] {
            "100%",
            "90%",
            "70%",
            "60%",
            "50%",
            "40%",
            "30%",
            "20%",
            "10%",
            "00%"});
            this.comboBoxPercentual.Location = new System.Drawing.Point(401, 76);
            this.comboBoxPercentual.Name = "comboBoxPercentual";
            this.comboBoxPercentual.Size = new System.Drawing.Size(72, 24);
            this.comboBoxPercentual.TabIndex = 9;
            // 
            // comboBoxPrioridade
            // 
            this.comboBoxPrioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrioridade.FormattingEnabled = true;
            this.comboBoxPrioridade.Items.AddRange(new object[] {
            "Um",
            "Dois",
            "Tres"});
            this.comboBoxPrioridade.Location = new System.Drawing.Point(140, 76);
            this.comboBoxPrioridade.Name = "comboBoxPrioridade";
            this.comboBoxPrioridade.Size = new System.Drawing.Size(72, 24);
            this.comboBoxPrioridade.TabIndex = 8;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(96, 42);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(272, 22);
            this.textBoxTitulo.TabIndex = 7;
            // 
            // labelPrioridade
            // 
            this.labelPrioridade.Location = new System.Drawing.Point(29, 76);
            this.labelPrioridade.Name = "labelPrioridade";
            this.labelPrioridade.Size = new System.Drawing.Size(92, 23);
            this.labelPrioridade.TabIndex = 6;
            this.labelPrioridade.Text = "Prioridade:";
            this.labelPrioridade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateCriacao
            // 
            this.dateCriacao.Location = new System.Drawing.Point(168, 111);
            this.dateCriacao.Name = "dateCriacao";
            this.dateCriacao.Size = new System.Drawing.Size(305, 22);
            this.dateCriacao.TabIndex = 5;
            // 
            // dateConclucao
            // 
            this.dateConclucao.Location = new System.Drawing.Point(168, 159);
            this.dateConclucao.Name = "dateConclucao";
            this.dateConclucao.Size = new System.Drawing.Size(305, 22);
            this.dateConclucao.TabIndex = 4;
            // 
            // labelParteConcluida
            // 
            this.labelParteConcluida.AutoSize = true;
            this.labelParteConcluida.Location = new System.Drawing.Point(234, 79);
            this.labelParteConcluida.Name = "labelParteConcluida";
            this.labelParteConcluida.Size = new System.Drawing.Size(146, 17);
            this.labelParteConcluida.TabIndex = 3;
            this.labelParteConcluida.Text = "Percentual Concluido:";
            // 
            // labelConclusao
            // 
            this.labelConclusao.Location = new System.Drawing.Point(44, 157);
            this.labelConclusao.Name = "labelConclusao";
            this.labelConclusao.Size = new System.Drawing.Size(118, 22);
            this.labelConclusao.TabIndex = 2;
            this.labelConclusao.Text = "Data Conclusão";
            this.labelConclusao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDataCriacao
            // 
            this.labelDataCriacao.Location = new System.Drawing.Point(44, 109);
            this.labelDataCriacao.Name = "labelDataCriacao";
            this.labelDataCriacao.Size = new System.Drawing.Size(118, 22);
            this.labelDataCriacao.TabIndex = 1;
            this.labelDataCriacao.Text = "Data Criação";
            this.labelDataCriacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Location = new System.Drawing.Point(29, 41);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(61, 23);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Titulo:";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mk_id
            // 
            this.mk_id.Enabled = false;
            this.mk_id.Location = new System.Drawing.Point(431, 42);
            this.mk_id.Name = "mk_id";
            this.mk_id.Size = new System.Drawing.Size(41, 22);
            this.mk_id.TabIndex = 11;
            // 
            // labelId
            // 
            this.labelId.Location = new System.Drawing.Point(383, 41);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(42, 23);
            this.labelId.TabIndex = 10;
            this.labelId.Text = "Id";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userControlBTN
            // 
            this.userControlBTN.Location = new System.Drawing.Point(39, 240);
            this.userControlBTN.Name = "userControlBTN";
            this.userControlBTN.Size = new System.Drawing.Size(525, 63);
            this.userControlBTN.TabIndex = 0;
            // 
            // FormTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 307);
            this.Controls.Add(this.gpTarefas);
            this.Controls.Add(this.userControlBTN);
            this.Name = "FormTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro Tarefas";
            this.gpTarefas.ResumeLayout(false);
            this.gpTarefas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlBTN userControlBTN;
        private System.Windows.Forms.GroupBox gpTarefas;
        private System.Windows.Forms.Label labelParteConcluida;
        private System.Windows.Forms.Label labelConclusao;
        private System.Windows.Forms.Label labelDataCriacao;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.DateTimePicker dateCriacao;
        private System.Windows.Forms.DateTimePicker dateConclucao;
        private System.Windows.Forms.ComboBox comboBoxPercentual;
        private System.Windows.Forms.ComboBox comboBoxPrioridade;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label labelPrioridade;
        private System.Windows.Forms.TextBox mk_id;
        private System.Windows.Forms.Label labelId;
    }
}