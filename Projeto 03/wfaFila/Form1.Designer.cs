
namespace wfaFila
{
    partial class Form1
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
            this.btInserir1 = new System.Windows.Forms.Button();
            this.txtMenu = new System.Windows.Forms.Label();
            this.btRemove = new System.Windows.Forms.Button();
            this.btInserir2 = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.tbInsere = new System.Windows.Forms.TextBox();
            this.tbRemove = new System.Windows.Forms.TextBox();
            this.txtInserir2 = new System.Windows.Forms.TextBox();
            this.txtPosicao = new System.Windows.Forms.TextBox();
            this.tbFila = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btInserir1
            // 
            this.btInserir1.Location = new System.Drawing.Point(12, 53);
            this.btInserir1.Name = "btInserir1";
            this.btInserir1.Size = new System.Drawing.Size(134, 35);
            this.btInserir1.TabIndex = 0;
            this.btInserir1.Text = "Inserir Inteiro";
            this.btInserir1.UseVisualStyleBackColor = true;
            this.btInserir1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMenu
            // 
            this.txtMenu.AutoSize = true;
            this.txtMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.txtMenu.Location = new System.Drawing.Point(174, 9);
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(90, 36);
            this.txtMenu.TabIndex = 1;
            this.txtMenu.Text = "Menu";
            this.txtMenu.Click += new System.EventHandler(this.label1_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(12, 94);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(134, 32);
            this.btRemove.TabIndex = 2;
            this.btRemove.Text = "Remover Inteiro";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.bt2_Click);
            // 
            // btInserir2
            // 
            this.btInserir2.Location = new System.Drawing.Point(12, 132);
            this.btInserir2.Name = "btInserir2";
            this.btInserir2.Size = new System.Drawing.Size(134, 34);
            this.btInserir2.TabIndex = 3;
            this.btInserir2.Text = "Inserir / Posição";
            this.btInserir2.UseVisualStyleBackColor = true;
            this.btInserir2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(12, 172);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(134, 34);
            this.btPrint.TabIndex = 4;
            this.btPrint.Text = "Imprimir a Fila";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.bt4_Click);
            // 
            // btExit
            // 
            this.btExit.FlatAppearance.BorderSize = 4;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btExit.Location = new System.Drawing.Point(51, 251);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(337, 32);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // tbInsere
            // 
            this.tbInsere.Location = new System.Drawing.Point(152, 59);
            this.tbInsere.Name = "tbInsere";
            this.tbInsere.Size = new System.Drawing.Size(120, 22);
            this.tbInsere.TabIndex = 6;
            // 
            // tbRemove
            // 
            this.tbRemove.Location = new System.Drawing.Point(152, 99);
            this.tbRemove.Name = "tbRemove";
            this.tbRemove.Size = new System.Drawing.Size(120, 22);
            this.tbRemove.TabIndex = 7;
            // 
            // txtInserir2
            // 
            this.txtInserir2.Location = new System.Drawing.Point(152, 138);
            this.txtInserir2.Name = "txtInserir2";
            this.txtInserir2.Size = new System.Drawing.Size(120, 22);
            this.txtInserir2.TabIndex = 8;
            // 
            // txtPosicao
            // 
            this.txtPosicao.Location = new System.Drawing.Point(278, 138);
            this.txtPosicao.Name = "txtPosicao";
            this.txtPosicao.Size = new System.Drawing.Size(120, 22);
            this.txtPosicao.TabIndex = 9;
            // 
            // tbFila
            // 
            this.tbFila.Location = new System.Drawing.Point(152, 178);
            this.tbFila.Name = "tbFila";
            this.tbFila.Size = new System.Drawing.Size(246, 22);
            this.tbFila.TabIndex = 11;
            this.tbFila.TextChanged += new System.EventHandler(this.txtPrint_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 310);
            this.Controls.Add(this.tbFila);
            this.Controls.Add(this.txtPosicao);
            this.Controls.Add(this.txtInserir2);
            this.Controls.Add(this.tbRemove);
            this.Controls.Add(this.tbInsere);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.btInserir2);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.txtMenu);
            this.Controls.Add(this.btInserir1);
            this.Name = "Form1";
            this.Text = "Menu Fila";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btInserir1;
        private System.Windows.Forms.Label txtMenu;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btInserir2;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.TextBox tbInsere;
        private System.Windows.Forms.TextBox tbRemove;
        private System.Windows.Forms.TextBox txtInserir2;
        private System.Windows.Forms.TextBox txtPosicao;
        private System.Windows.Forms.TextBox tbFila;
    }
}

