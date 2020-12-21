using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaTrab02Projeto02
{

    public partial class Form1 : Form
    {
        Pilha[] pilhas = new Pilha[5];
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            pilhas[0] = new Pilha(1);
            pilhas[1] = new Pilha(2);
            pilhas[2] = new Pilha(3);
            pilhas[3] = new Pilha(4);
            cboPilhas.Items.Add(pilhas[0]);
            cboPilhas.Items.Add(pilhas[1]);
            cboPilhas.Items.Add(pilhas[2]);
            cboPilhas.Items.Add(pilhas[3]);

        }
        private void butInserir_Click(object sender, EventArgs e)
        {
            bool espacoLivre = false;
            bool codigoLivre = true;
            string _codigo = txtboxCodigoPush.Text;
            // variaveis para obter menor pilha
            Pilha menor_pilha = pilhas[0];
            int menor_tamanho = menor_pilha.getNum_container();
            // percorrer pilhas
            for (int i = 0; i < 4; i++)
            {
                // obter menor pilha
                if (pilhas[i].getNum_container() < menor_tamanho)
                {
                    menor_tamanho = pilhas[i].getNum_container();
                    menor_pilha = pilhas[i];
                }
                // procurar por codigo repetido
                Container _topo = pilhas[i].getTopo();
                while (_topo != null)
                {
                    if (_topo.getCodigo() == _codigo)
                    {
                        codigoLivre = false;
                    }
                    _topo = _topo.getProx();
                }
            }
            // erro de codigo repetido
            if (!codigoLivre)
            { 
                MessageBox.Show("Código invalido!");
                return;
            }
            // empilhando na menor pilha
            if (menor_tamanho < 3)
            {
                menor_pilha.push(_codigo);
                espacoLivre = true;
            }
            // erro de falta de espaço nas pilhas
            if (!espacoLivre)
                MessageBox.Show("Impossível empilhar!");
        }

        private void butRemover_Click(object sender, EventArgs e)
        {
            bool codigoExiste = false;
            string _codigo = txtboxCodigoRemover.Text;
            // caso em que todas as pilhas estao vazias
            {
                int vazias = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (pilhas[i].isEmpty())
                        vazias++;
                }
                if (vazias == 4)
                {
                    MessageBox.Show("Impossível desempilhar!");
                    return;
                }
            }
            // percorrer as pilhas em busca do container 
            for (int i = 0; i < 4; i++)
            {
                Container _topo = pilhas[i].getTopo();
                while (_topo != null)
                {
                    if (_topo.getCodigo() == _codigo)
                    {
                        codigoExiste = true;
                        if (_topo == pilhas[i].getTopo())
                            // caso em que o container esta no topo e pode ser removido
                            pilhas[i].pop();
                        else
                            // caso em que o container nao esta no topo
                            MessageBox.Show("Impossível desempilhar!");
                        break;
                    }
                    _topo = _topo.getProx();
                }
                if (codigoExiste)
                    break;
            }
            // caso em que o container nao existe em nenhuma pilha
            if (!codigoExiste)
            {
                MessageBox.Show("Código invalido!");
                return;
            }
        }

        private void butExibirPilha_Click(object sender, EventArgs e)
        {
            Pilha _pilha = ((Pilha)cboPilhas.SelectedItem);
            Container _topo = _pilha.getTopo();

            string[] _relatorio = new string[3];
            int i = 0;
            while (_topo != null)
            {
               _relatorio[i] = "Container " + _topo.getCodigo();
                _topo = _topo.getProx();
                i++;
            }
            rtxtboxExibir.Lines = _relatorio;
        }
    }
}
