
namespace ControleTarefas15
{
    partial class FormMenuTarefa
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_prioridadeUm = new System.Windows.Forms.Button();
            this.dataGridDados = new System.Windows.Forms.DataGridView();
            this.btn_prioridadeDois = new System.Windows.Forms.Button();
            this.btn_prioridadeTres = new System.Windows.Forms.Button();
            this.labelTarefas = new System.Windows.Forms.Label();
            this.btn_AdicionarTarefa = new System.Windows.Forms.Button();
            this.btn_concluidas = new System.Windows.Forms.Button();
            this.btn_emAberto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_prioridadeUm
            // 
            this.btn_prioridadeUm.Location = new System.Drawing.Point(48, 87);
            this.btn_prioridadeUm.Name = "btn_prioridadeUm";
            this.btn_prioridadeUm.Size = new System.Drawing.Size(109, 60);
            this.btn_prioridadeUm.TabIndex = 0;
            this.btn_prioridadeUm.Text = "Prioridade Um";
            this.btn_prioridadeUm.UseVisualStyleBackColor = true;
            this.btn_prioridadeUm.Click += new System.EventHandler(this.btn_prioridadeUm_Click);
            // 
            // dataGridDados
            // 
            this.dataGridDados.AllowUserToAddRows = false;
            this.dataGridDados.AllowUserToDeleteRows = false;
            this.dataGridDados.AllowUserToResizeColumns = false;
            this.dataGridDados.AllowUserToResizeRows = false;
            this.dataGridDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridDados.Location = new System.Drawing.Point(29, 178);
            this.dataGridDados.Name = "dataGridDados";
            this.dataGridDados.RowHeadersWidth = 51;
            this.dataGridDados.RowTemplate.Height = 24;
            this.dataGridDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDados.Size = new System.Drawing.Size(768, 248);
            this.dataGridDados.TabIndex = 1;
            this.dataGridDados.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridDados_CellMouseDoubleClick);
            // 
            // btn_prioridadeDois
            // 
            this.btn_prioridadeDois.Location = new System.Drawing.Point(211, 87);
            this.btn_prioridadeDois.Name = "btn_prioridadeDois";
            this.btn_prioridadeDois.Size = new System.Drawing.Size(109, 60);
            this.btn_prioridadeDois.TabIndex = 2;
            this.btn_prioridadeDois.Text = "Prioridade Dois";
            this.btn_prioridadeDois.UseVisualStyleBackColor = true;
            this.btn_prioridadeDois.Click += new System.EventHandler(this.btn_prioridadeDois_Click);
            // 
            // btn_prioridadeTres
            // 
            this.btn_prioridadeTres.Location = new System.Drawing.Point(374, 87);
            this.btn_prioridadeTres.Name = "btn_prioridadeTres";
            this.btn_prioridadeTres.Size = new System.Drawing.Size(109, 60);
            this.btn_prioridadeTres.TabIndex = 3;
            this.btn_prioridadeTres.Text = "Prioridade Três";
            this.btn_prioridadeTres.UseVisualStyleBackColor = true;
            this.btn_prioridadeTres.Click += new System.EventHandler(this.btn_prioridadeTres_Click);
            // 
            // labelTarefas
            // 
            this.labelTarefas.AutoSize = true;
            this.labelTarefas.Location = new System.Drawing.Point(40, 158);
            this.labelTarefas.Name = "labelTarefas";
            this.labelTarefas.Size = new System.Drawing.Size(57, 17);
            this.labelTarefas.TabIndex = 4;
            this.labelTarefas.Text = "Tarefas";
            // 
            // btn_AdicionarTarefa
            // 
            this.btn_AdicionarTarefa.Location = new System.Drawing.Point(331, 12);
            this.btn_AdicionarTarefa.Name = "btn_AdicionarTarefa";
            this.btn_AdicionarTarefa.Size = new System.Drawing.Size(179, 57);
            this.btn_AdicionarTarefa.TabIndex = 5;
            this.btn_AdicionarTarefa.Text = "AdicionarTarefa";
            this.btn_AdicionarTarefa.UseVisualStyleBackColor = true;
            this.btn_AdicionarTarefa.Click += new System.EventHandler(this.btn_AdicionarTarefa_Click);
            // 
            // btn_concluidas
            // 
            this.btn_concluidas.Location = new System.Drawing.Point(688, 87);
            this.btn_concluidas.Name = "btn_concluidas";
            this.btn_concluidas.Size = new System.Drawing.Size(109, 60);
            this.btn_concluidas.TabIndex = 6;
            this.btn_concluidas.Text = "Concluidas";
            this.btn_concluidas.UseVisualStyleBackColor = true;
            this.btn_concluidas.Click += new System.EventHandler(this.btn_concluidas_Click);
            // 
            // btn_emAberto
            // 
            this.btn_emAberto.Location = new System.Drawing.Point(532, 87);
            this.btn_emAberto.Name = "btn_emAberto";
            this.btn_emAberto.Size = new System.Drawing.Size(109, 60);
            this.btn_emAberto.TabIndex = 7;
            this.btn_emAberto.Text = "Em Aberto";
            this.btn_emAberto.UseVisualStyleBackColor = true;
            this.btn_emAberto.Click += new System.EventHandler(this.btn_emAberto_Click);
            // 
            // FormMenuTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(this.btn_emAberto);
            this.Controls.Add(this.btn_concluidas);
            this.Controls.Add(this.btn_AdicionarTarefa);
            this.Controls.Add(this.labelTarefas);
            this.Controls.Add(this.btn_prioridadeTres);
            this.Controls.Add(this.btn_prioridadeDois);
            this.Controls.Add(this.dataGridDados);
            this.Controls.Add(this.btn_prioridadeUm);
            this.Name = "FormMenuTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu Tarefas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_prioridadeUm;
        private System.Windows.Forms.DataGridView dataGridDados;
        private System.Windows.Forms.Button btn_prioridadeDois;
        private System.Windows.Forms.Button btn_prioridadeTres;
        private System.Windows.Forms.Label labelTarefas;
        private System.Windows.Forms.Button btn_AdicionarTarefa;
        private System.Windows.Forms.Button btn_concluidas;
        private System.Windows.Forms.Button btn_emAberto;
    }
}

