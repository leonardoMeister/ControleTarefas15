
namespace ControleTarefas15.MenusControleGrid
{
    partial class FormMenuCompromissos
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
            this.dataGridDados = new System.Windows.Forms.DataGridView();
            this.btn_compromisso = new System.Windows.Forms.Button();
            this.btn_dataDefinida = new System.Windows.Forms.Button();
            this.dataDefinida = new System.Windows.Forms.DateTimePicker();
            this.btn_hoje = new System.Windows.Forms.Button();
            this.btn_semana = new System.Windows.Forms.Button();
            this.btn_futuro = new System.Windows.Forms.Button();
            this.btn_passado = new System.Windows.Forms.Button();
            this.btn_todosDados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDados
            // 
            this.dataGridDados.AllowUserToAddRows = false;
            this.dataGridDados.AllowUserToDeleteRows = false;
            this.dataGridDados.AllowUserToResizeColumns = false;
            this.dataGridDados.AllowUserToResizeRows = false;
            this.dataGridDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridDados.Location = new System.Drawing.Point(12, 181);
            this.dataGridDados.Name = "dataGridDados";
            this.dataGridDados.RowHeadersWidth = 51;
            this.dataGridDados.RowTemplate.Height = 24;
            this.dataGridDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDados.Size = new System.Drawing.Size(768, 257);
            this.dataGridDados.TabIndex = 7;
            this.dataGridDados.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridDados_CellMouseDoubleClick);
            // 
            // btn_compromisso
            // 
            this.btn_compromisso.Location = new System.Drawing.Point(12, 12);
            this.btn_compromisso.Name = "btn_compromisso";
            this.btn_compromisso.Size = new System.Drawing.Size(191, 53);
            this.btn_compromisso.TabIndex = 8;
            this.btn_compromisso.Text = "Adicionar Compromisso";
            this.btn_compromisso.UseVisualStyleBackColor = true;
            this.btn_compromisso.Click += new System.EventHandler(this.btn_compromisso_Click);
            // 
            // btn_dataDefinida
            // 
            this.btn_dataDefinida.Location = new System.Drawing.Point(584, 137);
            this.btn_dataDefinida.Name = "btn_dataDefinida";
            this.btn_dataDefinida.Size = new System.Drawing.Size(196, 38);
            this.btn_dataDefinida.TabIndex = 12;
            this.btn_dataDefinida.Text = "Pesquisar Até a Data";
            this.btn_dataDefinida.UseVisualStyleBackColor = true;
            this.btn_dataDefinida.Click += new System.EventHandler(this.btn_dataDefinida_Click);
            // 
            // dataDefinida
            // 
            this.dataDefinida.Location = new System.Drawing.Point(291, 146);
            this.dataDefinida.Name = "dataDefinida";
            this.dataDefinida.Size = new System.Drawing.Size(287, 22);
            this.dataDefinida.TabIndex = 13;
            // 
            // btn_hoje
            // 
            this.btn_hoje.Location = new System.Drawing.Point(639, 49);
            this.btn_hoje.Name = "btn_hoje";
            this.btn_hoje.Size = new System.Drawing.Size(141, 38);
            this.btn_hoje.TabIndex = 14;
            this.btn_hoje.Text = "Pesquisar Hoje";
            this.btn_hoje.UseVisualStyleBackColor = true;
            this.btn_hoje.Click += new System.EventHandler(this.btn_hoje_Click);
            // 
            // btn_semana
            // 
            this.btn_semana.Location = new System.Drawing.Point(639, 93);
            this.btn_semana.Name = "btn_semana";
            this.btn_semana.Size = new System.Drawing.Size(141, 38);
            this.btn_semana.TabIndex = 15;
            this.btn_semana.Text = "Pesquisar Semana";
            this.btn_semana.UseVisualStyleBackColor = true;
            this.btn_semana.Click += new System.EventHandler(this.btn_semana_Click);
            // 
            // btn_futuro
            // 
            this.btn_futuro.Location = new System.Drawing.Point(12, 71);
            this.btn_futuro.Name = "btn_futuro";
            this.btn_futuro.Size = new System.Drawing.Size(157, 46);
            this.btn_futuro.TabIndex = 16;
            this.btn_futuro.Text = "Pesquisar Futuro";
            this.btn_futuro.UseVisualStyleBackColor = true;
            this.btn_futuro.Click += new System.EventHandler(this.btn_futuro_Click);
            // 
            // btn_passado
            // 
            this.btn_passado.Location = new System.Drawing.Point(12, 122);
            this.btn_passado.Name = "btn_passado";
            this.btn_passado.Size = new System.Drawing.Size(157, 46);
            this.btn_passado.TabIndex = 17;
            this.btn_passado.Text = "Pesquisar Passado";
            this.btn_passado.UseVisualStyleBackColor = true;
            this.btn_passado.Click += new System.EventHandler(this.btn_passado_Click);
            // 
            // btn_todosDados
            // 
            this.btn_todosDados.Location = new System.Drawing.Point(639, 5);
            this.btn_todosDados.Name = "btn_todosDados";
            this.btn_todosDados.Size = new System.Drawing.Size(141, 38);
            this.btn_todosDados.TabIndex = 18;
            this.btn_todosDados.Text = "Todos Dados";
            this.btn_todosDados.UseVisualStyleBackColor = true;
            this.btn_todosDados.Click += new System.EventHandler(this.btn_todosDados_Click);
            // 
            // FormMenuCompromissos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_todosDados);
            this.Controls.Add(this.btn_passado);
            this.Controls.Add(this.btn_futuro);
            this.Controls.Add(this.btn_semana);
            this.Controls.Add(this.btn_hoje);
            this.Controls.Add(this.dataDefinida);
            this.Controls.Add(this.btn_dataDefinida);
            this.Controls.Add(this.btn_compromisso);
            this.Controls.Add(this.dataGridDados);
            this.Name = "FormMenuCompromissos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu Compromissos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDados;
        private System.Windows.Forms.Button btn_compromisso;
        private System.Windows.Forms.Button btn_dataDefinida;
        private System.Windows.Forms.DateTimePicker dataDefinida;
        private System.Windows.Forms.Button btn_hoje;
        private System.Windows.Forms.Button btn_semana;
        private System.Windows.Forms.Button btn_futuro;
        private System.Windows.Forms.Button btn_passado;
        private System.Windows.Forms.Button btn_todosDados;
    }
}