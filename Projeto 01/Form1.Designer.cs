namespace wfaTrabalho02Projeto01
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
            this.rtxRelatorio = new System.Windows.Forms.RichTextBox();
            this.butRegistraFatura = new System.Windows.Forms.Button();
            this.butDeletaFaturas = new System.Windows.Forms.Button();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxRelatorio
            // 
            this.rtxRelatorio.Location = new System.Drawing.Point(12, 68);
            this.rtxRelatorio.Name = "rtxRelatorio";
            this.rtxRelatorio.Size = new System.Drawing.Size(410, 421);
            this.rtxRelatorio.TabIndex = 0;
            this.rtxRelatorio.Text = "";
            // 
            // butRegistraFatura
            // 
            this.butRegistraFatura.Location = new System.Drawing.Point(12, 39);
            this.butRegistraFatura.Name = "butRegistraFatura";
            this.butRegistraFatura.Size = new System.Drawing.Size(176, 23);
            this.butRegistraFatura.TabIndex = 1;
            this.butRegistraFatura.Text = "Registrar novo pagamento";
            this.butRegistraFatura.UseVisualStyleBackColor = true;
            this.butRegistraFatura.Click += new System.EventHandler(this.butRegistraFatura_Click);
            // 
            // butDeletaFaturas
            // 
            this.butDeletaFaturas.Location = new System.Drawing.Point(246, 39);
            this.butDeletaFaturas.Name = "butDeletaFaturas";
            this.butDeletaFaturas.Size = new System.Drawing.Size(176, 23);
            this.butDeletaFaturas.TabIndex = 3;
            this.butDeletaFaturas.Text = "Limpar todos os pagamentos";
            this.butDeletaFaturas.UseVisualStyleBackColor = true;
            this.butDeletaFaturas.Click += new System.EventHandler(this.butDeletaFaturas_Click);
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.BackColor = System.Drawing.Color.Gold;
            this.lblTitulo1.Location = new System.Drawing.Point(160, 9);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(114, 13);
            this.lblTitulo1.TabIndex = 4;
            this.lblTitulo1.Text = "Gerenciar pagamentos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 501);
            this.Controls.Add(this.lblTitulo1);
            this.Controls.Add(this.butDeletaFaturas);
            this.Controls.Add(this.butRegistraFatura);
            this.Controls.Add(this.rtxRelatorio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxRelatorio;
        private System.Windows.Forms.Button butRegistraFatura;
        private System.Windows.Forms.Button butDeletaFaturas;
        private System.Windows.Forms.Label lblTitulo1;
    }
}

