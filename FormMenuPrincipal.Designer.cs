
namespace ControleTarefas15
{
    partial class FormMenuPrincipal
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
            this.btn_tarefas = new System.Windows.Forms.Button();
            this.btn_contatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_compromissos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_tarefas
            // 
            this.btn_tarefas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_tarefas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tarefas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_tarefas.Location = new System.Drawing.Point(58, 58);
            this.btn_tarefas.Name = "btn_tarefas";
            this.btn_tarefas.Size = new System.Drawing.Size(223, 132);
            this.btn_tarefas.TabIndex = 0;
            this.btn_tarefas.Text = "Controle Tarefas";
            this.btn_tarefas.UseVisualStyleBackColor = false;
            this.btn_tarefas.Click += new System.EventHandler(this.btn_tarefas_Click);
            // 
            // btn_contatos
            // 
            this.btn_contatos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_contatos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contatos.Location = new System.Drawing.Point(58, 193);
            this.btn_contatos.Name = "btn_contatos";
            this.btn_contatos.Size = new System.Drawing.Size(223, 132);
            this.btn_contatos.TabIndex = 1;
            this.btn_contatos.Text = "Controle Contatos";
            this.btn_contatos.UseVisualStyleBackColor = false;
            this.btn_contatos.Click += new System.EventHandler(this.btn_contatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escolha Sua Opção";
            // 
            // btn_compromissos
            // 
            this.btn_compromissos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_compromissos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compromissos.Location = new System.Drawing.Point(58, 331);
            this.btn_compromissos.Name = "btn_compromissos";
            this.btn_compromissos.Size = new System.Drawing.Size(223, 132);
            this.btn_compromissos.TabIndex = 3;
            this.btn_compromissos.Text = "Controle Compromissos";
            this.btn_compromissos.UseVisualStyleBackColor = false;
            this.btn_compromissos.Click += new System.EventHandler(this.btn_compromissos_Click);
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(349, 529);
            this.Controls.Add(this.btn_compromissos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_contatos);
            this.Controls.Add(this.btn_tarefas);
            this.Name = "FormMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tarefas;
        private System.Windows.Forms.Button btn_contatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_compromissos;
    }
}