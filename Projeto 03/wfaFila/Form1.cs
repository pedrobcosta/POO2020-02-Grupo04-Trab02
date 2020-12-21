using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaFila
{
    public partial class Form1 : Form
    {
        Fila minhafila = new Fila();
        Fila minhafilinha = new Fila();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int item = 0;
            try
            {
                item = Int32.Parse(tbInsere.Text);
            }
            catch (FormatException)
            {
                tbInsere.Clear();
                MessageBox.Show("O item deve ser um inteiro!", "Item inválido");
            }
            if (tbInsere.Text.Length > 0)
            {
                minhafila.inserir(item);
            }
            tbInsere.Clear();
            tbFila.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int item = 0;
            int item2 = 0;
            try
            {
                item = Int32.Parse(txtInserir2.Text);
                item2 = Int32.Parse(txtPosicao.Text);
            }
            catch (FormatException)
            {
                txtInserir2.Clear();
                txtPosicao.Clear();
                MessageBox.Show("Os itens devem ser inteiros!", "Itens inválidos");
            }
            if (txtInserir2.Text.Length > 0 && txtPosicao.Text.Length > 0)
            {
                minhafila.inserirdps(item, item2);
            }
            txtInserir2.Clear();
            txtPosicao.Clear();
            tbFila.Clear();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            tbFila.Clear();
            NohFila temp = minhafila.start;
            if (minhafila.isEmpty())
            {
                tbFila.Clear();
                MessageBox.Show("Não há itens na Fila!", "Fila vazia");
            }

            else
            {
                while (temp != null)
                {
                    tbFila.Text = tbFila.Text + "  " + Convert.ToString(temp.getData());
                    temp = temp.getNext();
                }
            }
        }

        private void bt2_Click(object sender, EventArgs e) //REMOVER
        {
            int item;
            try
            {
                item = Int32.Parse(tbRemove.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("O item deve ser um inteiro!", "Item inválido");
            }
            if (tbRemove.Text.Length > 0)
            {
                if (minhafila.achaNoh(Convert.ToInt32(tbRemove.Text)) == null)
                {
                    tbRemove.Clear();
                    MessageBox.Show("Item não econtrado");
                }
                else
                {
                    minhafila.remove(Convert.ToInt32(tbRemove.Text));

                }
            }
            tbRemove.Clear();
            tbFila.Clear();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide(); 
        }

        private void txtPrint_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
