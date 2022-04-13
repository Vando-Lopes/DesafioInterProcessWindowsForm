namespace DesafioInterProcess
{
    partial class Form1
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
            this.btnNovoPaciente = new System.Windows.Forms.Button();
            this.dataGridPacientes = new System.Windows.Forms.DataGridView();
            this.btnListarPacientes = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.btnExcluirPaciente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovoPaciente
            // 
            this.btnNovoPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoPaciente.Location = new System.Drawing.Point(12, 12);
            this.btnNovoPaciente.Name = "btnNovoPaciente";
            this.btnNovoPaciente.Size = new System.Drawing.Size(114, 23);
            this.btnNovoPaciente.TabIndex = 0;
            this.btnNovoPaciente.Text = "Novo Paciente";
            this.btnNovoPaciente.UseVisualStyleBackColor = true;
            this.btnNovoPaciente.Click += new System.EventHandler(this.btnNovoPacienteClick);
            // 
            // dataGridPacientes
            // 
            this.dataGridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPacientes.Location = new System.Drawing.Point(3, 41);
            this.dataGridPacientes.Name = "dataGridPacientes";
            this.dataGridPacientes.Size = new System.Drawing.Size(818, 302);
            this.dataGridPacientes.StandardTab = true;
            this.dataGridPacientes.TabIndex = 1;
            // 
            // btnListarPacientes
            // 
            this.btnListarPacientes.Location = new System.Drawing.Point(141, 12);
            this.btnListarPacientes.Name = "btnListarPacientes";
            this.btnListarPacientes.Size = new System.Drawing.Size(127, 23);
            this.btnListarPacientes.TabIndex = 2;
            this.btnListarPacientes.Text = "Listar Pacientes";
            this.btnListarPacientes.UseVisualStyleBackColor = true;
            this.btnListarPacientes.Click += new System.EventHandler(this.btnListarPacientes_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(284, 12);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(123, 23);
            this.buttonAlterar.TabIndex = 3;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // btnExcluirPaciente
            // 
            this.btnExcluirPaciente.Location = new System.Drawing.Point(424, 12);
            this.btnExcluirPaciente.Name = "btnExcluirPaciente";
            this.btnExcluirPaciente.Size = new System.Drawing.Size(123, 23);
            this.btnExcluirPaciente.TabIndex = 4;
            this.btnExcluirPaciente.Text = "Excluir Paciente";
            this.btnExcluirPaciente.UseVisualStyleBackColor = true;
            this.btnExcluirPaciente.Click += new System.EventHandler(this.btnExcluirPaciente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 354);
            this.Controls.Add(this.btnExcluirPaciente);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.btnListarPacientes);
            this.Controls.Add(this.dataGridPacientes);
            this.Controls.Add(this.btnNovoPaciente);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovoPaciente;
        private System.Windows.Forms.DataGridView dataGridPacientes;
        private System.Windows.Forms.Button btnListarPacientes;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button btnExcluirPaciente;
    }
}

