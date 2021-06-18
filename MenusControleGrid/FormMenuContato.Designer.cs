
namespace ControleTarefas15
{
    partial class FormMenuContato
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
            this.btn_AdicionarTarefa = new System.Windows.Forms.Button();
            this.dataGridDados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.mk_pesquisa = new System.Windows.Forms.TextBox();
            this.btn_busca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AdicionarTarefa
            // 
            this.btn_AdicionarTarefa.Location = new System.Drawing.Point(12, 12);
            this.btn_AdicionarTarefa.Name = "btn_AdicionarTarefa";
            this.btn_AdicionarTarefa.Size = new System.Drawing.Size(179, 57);
            this.btn_AdicionarTarefa.TabIndex = 7;
            this.btn_AdicionarTarefa.Text = "Adicionar Contato";
            this.btn_AdicionarTarefa.UseVisualStyleBackColor = true;
            this.btn_AdicionarTarefa.Click += new System.EventHandler(this.btn_AdicionarTarefa_Click);
            // 
            // dataGridDados
            // 
            this.dataGridDados.AllowUserToAddRows = false;
            this.dataGridDados.AllowUserToDeleteRows = false;
            this.dataGridDados.AllowUserToResizeColumns = false;
            this.dataGridDados.AllowUserToResizeRows = false;
            this.dataGridDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridDados.Location = new System.Drawing.Point(12, 139);
            this.dataGridDados.Name = "dataGridDados";
            this.dataGridDados.RowHeadersWidth = 51;
            this.dataGridDados.RowTemplate.Height = 24;
            this.dataGridDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDados.Size = new System.Drawing.Size(768, 257);
            this.dataGridDados.TabIndex = 6;
            this.dataGridDados.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridDados_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Contatos";
            // 
            // mk_pesquisa
            // 
            this.mk_pesquisa.Location = new System.Drawing.Point(478, 103);
            this.mk_pesquisa.Name = "mk_pesquisa";
            this.mk_pesquisa.Size = new System.Drawing.Size(155, 22);
            this.mk_pesquisa.TabIndex = 9;
            // 
            // btn_busca
            // 
            this.btn_busca.Location = new System.Drawing.Point(639, 95);
            this.btn_busca.Name = "btn_busca";
            this.btn_busca.Size = new System.Drawing.Size(141, 38);
            this.btn_busca.TabIndex = 10;
            this.btn_busca.Text = "Pesquisar Cargo";
            this.btn_busca.UseVisualStyleBackColor = true;
            this.btn_busca.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMenuContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.btn_busca);
            this.Controls.Add(this.mk_pesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AdicionarTarefa);
            this.Controls.Add(this.dataGridDados);
            this.Name = "FormMenuContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu Contato";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AdicionarTarefa;
        private System.Windows.Forms.DataGridView dataGridDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mk_pesquisa;
        private System.Windows.Forms.Button btn_busca;
    }
}