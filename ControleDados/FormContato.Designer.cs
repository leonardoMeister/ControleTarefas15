
namespace ControleTarefas15
{
    partial class FormContato
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
            this.textBoxCargo = new System.Windows.Forms.TextBox();
            this.labelCargo = new System.Windows.Forms.Label();
            this.textBoxEmpresa = new System.Windows.Forms.TextBox();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.mk_telefone = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.mk_id = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.userControlBTN = new ControleTarefas15.UserControlBTN();
            this.gpTarefas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpTarefas
            // 
            this.gpTarefas.Controls.Add(this.textBoxCargo);
            this.gpTarefas.Controls.Add(this.labelCargo);
            this.gpTarefas.Controls.Add(this.textBoxEmpresa);
            this.gpTarefas.Controls.Add(this.labelEmpresa);
            this.gpTarefas.Controls.Add(this.labelTelefone);
            this.gpTarefas.Controls.Add(this.mk_telefone);
            this.gpTarefas.Controls.Add(this.textBoxEmail);
            this.gpTarefas.Controls.Add(this.labelEmail);
            this.gpTarefas.Controls.Add(this.mk_id);
            this.gpTarefas.Controls.Add(this.labelId);
            this.gpTarefas.Controls.Add(this.textBoxNome);
            this.gpTarefas.Controls.Add(this.labelNome);
            this.gpTarefas.Location = new System.Drawing.Point(39, 20);
            this.gpTarefas.Name = "gpTarefas";
            this.gpTarefas.Size = new System.Drawing.Size(525, 197);
            this.gpTarefas.TabIndex = 3;
            this.gpTarefas.TabStop = false;
            this.gpTarefas.Text = "Cadastro Contato";
            // 
            // textBoxCargo
            // 
            this.textBoxCargo.Location = new System.Drawing.Point(335, 118);
            this.textBoxCargo.Name = "textBoxCargo";
            this.textBoxCargo.Size = new System.Drawing.Size(184, 22);
            this.textBoxCargo.TabIndex = 19;
            // 
            // labelCargo
            // 
            this.labelCargo.Location = new System.Drawing.Point(252, 118);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(77, 23);
            this.labelCargo.TabIndex = 18;
            this.labelCargo.Text = "Cargo:";
            this.labelCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxEmpresa
            // 
            this.textBoxEmpresa.Location = new System.Drawing.Point(96, 160);
            this.textBoxEmpresa.Name = "textBoxEmpresa";
            this.textBoxEmpresa.Size = new System.Drawing.Size(272, 22);
            this.textBoxEmpresa.TabIndex = 17;
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.Location = new System.Drawing.Point(15, 159);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(77, 23);
            this.labelEmpresa.TabIndex = 16;
            this.labelEmpresa.Text = "Empresa: ";
            this.labelEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTelefone
            // 
            this.labelTelefone.Location = new System.Drawing.Point(6, 117);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(86, 23);
            this.labelTelefone.TabIndex = 15;
            this.labelTelefone.Text = "Telefone:";
            this.labelTelefone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mk_telefone
            // 
            this.mk_telefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mk_telefone.Location = new System.Drawing.Point(98, 118);
            this.mk_telefone.Mask = "00000 0000";
            this.mk_telefone.Name = "mk_telefone";
            this.mk_telefone.Size = new System.Drawing.Size(148, 22);
            this.mk_telefone.TabIndex = 14;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(96, 79);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(272, 22);
            this.textBoxEmail.TabIndex = 13;
            // 
            // labelEmail
            // 
            this.labelEmail.Location = new System.Drawing.Point(29, 78);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(61, 23);
            this.labelEmail.TabIndex = 12;
            this.labelEmail.Text = "Email:";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(96, 42);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(272, 22);
            this.textBoxNome.TabIndex = 7;
            // 
            // labelNome
            // 
            this.labelNome.Location = new System.Drawing.Point(29, 41);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(61, 23);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            this.labelNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userControlBTN
            // 
            this.userControlBTN.Location = new System.Drawing.Point(39, 223);
            this.userControlBTN.Name = "userControlBTN";
            this.userControlBTN.Size = new System.Drawing.Size(525, 63);
            this.userControlBTN.TabIndex = 2;
            // 
            // FormContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 306);
            this.Controls.Add(this.gpTarefas);
            this.Controls.Add(this.userControlBTN);
            this.Name = "FormContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro Contatos";
            this.gpTarefas.ResumeLayout(false);
            this.gpTarefas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpTarefas;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelNome;
        private UserControlBTN userControlBTN;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.Label labelEmpresa;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelEmail;
        public System.Windows.Forms.TextBox mk_id;
        public System.Windows.Forms.TextBox textBoxNome;
        public System.Windows.Forms.TextBox textBoxCargo;
        public System.Windows.Forms.TextBox textBoxEmpresa;
        public System.Windows.Forms.MaskedTextBox mk_telefone;
        public System.Windows.Forms.TextBox textBoxEmail;
    }
}