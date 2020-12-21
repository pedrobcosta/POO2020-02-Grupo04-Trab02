namespace wfaTrab02Projeto02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.lblCodigo1 = new System.Windows.Forms.Label();
            this.txtboxCodigoPush = new System.Windows.Forms.TextBox();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butInserir = new System.Windows.Forms.Button();
            this.butRemover = new System.Windows.Forms.Button();
            this.txtboxCodigoRemover = new System.Windows.Forms.TextBox();
            this.lblTitulo3 = new System.Windows.Forms.Label();
            this.rtxtboxExibir = new System.Windows.Forms.RichTextBox();
            this.cboPilhas = new System.Windows.Forms.ComboBox();
            this.butExibirPilha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.BackColor = System.Drawing.Color.LimeGreen;
            this.lblTitulo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTitulo1.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(84, 15);
            this.lblTitulo1.TabIndex = 0;
            this.lblTitulo1.Text = "Inserir container";
            // 
            // lblCodigo1
            // 
            this.lblCodigo1.AutoSize = true;
            this.lblCodigo1.Location = new System.Drawing.Point(42, 36);
            this.lblCodigo1.Name = "lblCodigo1";
            this.lblCodigo1.Size = new System.Drawing.Size(105, 13);
            this.lblCodigo1.TabIndex = 1;
            this.lblCodigo1.Text = "Código do container:";
            // 
            // txtboxCodigoPush
            // 
            this.txtboxCodigoPush.Location = new System.Drawing.Point(153, 33);
            this.txtboxCodigoPush.Name = "txtboxCodigoPush";
            this.txtboxCodigoPush.Size = new System.Drawing.Size(200, 20);
            this.txtboxCodigoPush.TabIndex = 2;
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.BackColor = System.Drawing.Color.Salmon;
            this.lblTitulo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTitulo2.Location = new System.Drawing.Point(12, 92);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(99, 15);
            this.lblTitulo2.TabIndex = 3;
            this.lblTitulo2.Text = "Remover container";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código do container:";
            // 
            // butInserir
            // 
            this.butInserir.Location = new System.Drawing.Point(278, 59);
            this.butInserir.Name = "butInserir";
            this.butInserir.Size = new System.Drawing.Size(75, 23);
            this.butInserir.TabIndex = 6;
            this.butInserir.Text = "Inserir";
            this.butInserir.UseVisualStyleBackColor = true;
            this.butInserir.Click += new System.EventHandler(this.butInserir_Click);
            // 
            // butRemover
            // 
            this.butRemover.Location = new System.Drawing.Point(278, 142);
            this.butRemover.Name = "butRemover";
            this.butRemover.Size = new System.Drawing.Size(75, 23);
            this.butRemover.TabIndex = 7;
            this.butRemover.Text = "Remover";
            this.butRemover.UseVisualStyleBackColor = true;
            this.butRemover.Click += new System.EventHandler(this.butRemover_Click);
            // 
            // txtboxCodigoRemover
            // 
            this.txtboxCodigoRemover.Location = new System.Drawing.Point(153, 116);
            this.txtboxCodigoRemover.Name = "txtboxCodigoRemover";
            this.txtboxCodigoRemover.Size = new System.Drawing.Size(200, 20);
            this.txtboxCodigoRemover.TabIndex = 10;
            // 
            // lblTitulo3
            // 
            this.lblTitulo3.AutoSize = true;
            this.lblTitulo3.Location = new System.Drawing.Point(9, 187);
            this.lblTitulo3.Name = "lblTitulo3";
            this.lblTitulo3.Size = new System.Drawing.Size(60, 13);
            this.lblTitulo3.TabIndex = 11;
            this.lblTitulo3.Text = "Exibir pilha:";
            // 
            // rtxtboxExibir
            // 
            this.rtxtboxExibir.Location = new System.Drawing.Point(12, 211);
            this.rtxtboxExibir.Name = "rtxtboxExibir";
            this.rtxtboxExibir.Size = new System.Drawing.Size(341, 51);
            this.rtxtboxExibir.TabIndex = 12;
            this.rtxtboxExibir.Text = "";
            // 
            // cboPilhas
            // 
            this.cboPilhas.FormattingEnabled = true;
            this.cboPilhas.Location = new System.Drawing.Point(75, 184);
            this.cboPilhas.Name = "cboPilhas";
            this.cboPilhas.Size = new System.Drawing.Size(197, 21);
            this.cboPilhas.TabIndex = 13;
            // 
            // butExibirPilha
            // 
            this.butExibirPilha.Location = new System.Drawing.Point(278, 182);
            this.butExibirPilha.Name = "butExibirPilha";
            this.butExibirPilha.Size = new System.Drawing.Size(75, 23);
            this.butExibirPilha.TabIndex = 14;
            this.butExibirPilha.Text = "Exibir";
            this.butExibirPilha.UseVisualStyleBackColor = true;
            this.butExibirPilha.Click += new System.EventHandler(this.butExibirPilha_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 274);
            this.Controls.Add(this.butExibirPilha);
            this.Controls.Add(this.cboPilhas);
            this.Controls.Add(this.rtxtboxExibir);
            this.Controls.Add(this.lblTitulo3);
            this.Controls.Add(this.txtboxCodigoRemover);
            this.Controls.Add(this.butRemover);
            this.Controls.Add(this.butInserir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.txtboxCodigoPush);
            this.Controls.Add(this.lblCodigo1);
            this.Controls.Add(this.lblTitulo1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gerenciador do Porto Seco";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label lblCodigo1;
        private System.Windows.Forms.TextBox txtboxCodigoPush;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butInserir;
        private System.Windows.Forms.Button butRemover;
        private System.Windows.Forms.TextBox txtboxCodigoRemover;
        private System.Windows.Forms.Label lblTitulo3;
        private System.Windows.Forms.RichTextBox rtxtboxExibir;
        private System.Windows.Forms.ComboBox cboPilhas;
        private System.Windows.Forms.Button butExibirPilha;
    }
}

