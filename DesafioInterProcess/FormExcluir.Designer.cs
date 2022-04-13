namespace DesafioInterProcess
{
    partial class FormExcluir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExcluir));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSimExcluir = new System.Windows.Forms.Button();
            this.btnNaoExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deseja realmente excluir este paciente ?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnSimExcluir
            // 
            this.btnSimExcluir.Location = new System.Drawing.Point(140, 92);
            this.btnSimExcluir.Name = "btnSimExcluir";
            this.btnSimExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnSimExcluir.TabIndex = 2;
            this.btnSimExcluir.Text = "Sim";
            this.btnSimExcluir.UseVisualStyleBackColor = true;
            this.btnSimExcluir.Click += new System.EventHandler(this.btnSimExcluir_Click);
            // 
            // btnNaoExcluir
            // 
            this.btnNaoExcluir.Location = new System.Drawing.Point(244, 92);
            this.btnNaoExcluir.Name = "btnNaoExcluir";
            this.btnNaoExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnNaoExcluir.TabIndex = 3;
            this.btnNaoExcluir.Text = "Não";
            this.btnNaoExcluir.UseVisualStyleBackColor = true;
            this.btnNaoExcluir.Click += new System.EventHandler(this.btnNaoExcluir_Click);
            // 
            // FormExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 169);
            this.Controls.Add(this.btnNaoExcluir);
            this.Controls.Add(this.btnSimExcluir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormExcluir";
            this.Text = "FormExcluir";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSimExcluir;
        private System.Windows.Forms.Button btnNaoExcluir;
    }
}