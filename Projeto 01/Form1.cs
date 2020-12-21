using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaTrabalho02Projeto01
{
    public partial class Form1 : Form
    {
        Alimentacao[] pagtosAliment = new Alimentacao[3];
        Saude[] pagtosSaude = new Saude[3];

        public Form1()
        {
            InitializeComponent();
        }

        private void butRegistraFatura_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            int tipo;
            // gerando tipo de pagamento aleatorio
            if (pagtosAliment[2] == null & pagtosSaude[2] == null)
                tipo = rand.Next(2);    // aleatorio
            else if (pagtosAliment[2] == null & pagtosSaude[2] != null)
                tipo = 0;               // alimentacao
            else if (pagtosAliment[2] != null & pagtosSaude[2] == null)
                tipo = 1;               // saude
            else
            {
                tipo = -1;              // limite atingido
                MessageBox.Show("Impossível gerar mais pagamentos");
                return;
            }
            // Gerando pagamento aleatorio
           
            // cpf
            long _cpf = LongRandom(10000000000, 99999999999, rand);
            // valor
            double _valor = rand.Next(1000) + Math.Round(rand.NextDouble(),2);
            // codigo
            int _cod = rand.Next(1000, 9999);

            // Gerando pagamento aleatorio de alimentacao
            if (tipo == 0)
            {
                Alimentacao novo_pagto = new Alimentacao();
                for (int i = 0; i < 3; i++)
                {
                    if (pagtosAliment[i] == null)
                    {
                        pagtosAliment[i] = novo_pagto;
                        break;
                    }
                }
                // descricao
                String[] lista_descricao = { "Maçã","Abacate","Banana","Mirtilo","Laranja","Morango","Ovos",
                "Carne bovina","Peitos de frango","Cordeiro","Amêndoas","Sementes de Chia","Cocos","Macadâmia",
                "Nozes","Amendoins","Aspargos","Pimentão","Brócolis","Cenouras","Couve-flor","Couve","Pepino",
                "Alho","Cebola","Tomates","Salmão","Sardinhas","Crustáceos","Camarão","Truta","Atum","Arroz Integral",
                "Arroz Branco","Aveia","Quinoa","Pão Ezequiel","Pães Caseiros","Feijão verde","Feijão Carioca",
                "Lentilhas","Queijo","Leite integral","Iogurte","Óleo de coco","Azeite extra virgem","Manteiga de vaca",
                "Manteiga de Cabra","Batatas","Batata-doce","Vinagre de maçã","Chocolate amargo"};
                int indice = rand.Next(lista_descricao.Length);
                string _descricao = lista_descricao[indice];
                // atribuicoes e faturar
                novo_pagto.setCpf(_cpf);
                novo_pagto.setValor(_valor);
                novo_pagto.setCod(_cod);
                novo_pagto.setDescricao(_descricao);
                novo_pagto.faturar();            
            }

            // Gerando pagamento aleatorio de saude
            else if (tipo == 1)
            {
                Saude novo_pagto = new Saude();
                for (int i = 0; i < 3; i++)
                {
                    if (pagtosSaude[i] == null)
                    {
                        pagtosSaude[i] = novo_pagto;
                        break;
                    }
                }
                // estabelecimento
                String[] lista_estabelecimento = {"CVS Pharmacy", "Walgreens","Walmart Pharmacies","Rite Aid",
                "Publix Pharmacies","SuperValu","Hy-Vee","Winn-Dixie Pharmacies","Giant Eagle Pharmacy",
                "H-E-B Drug Stores","Fred's Pharmacy","Bartell Drugs","CommCare Pharmacy","Kinney Drugs",
                "Herb Day","Vitamin World","Trinity Pharmacy","UCB Pharma","Apollo Pharmacy",
                "Premier Care Pharmacy","PharmaSave","Medicap Pharmacy","Med Quest Pharmacy",
                "Corner Drug Health Mart Pharmacy","The Compounding Center Pharmacy"};
                int indice = rand.Next(lista_estabelecimento.Length);
                string _estabelecimento = lista_estabelecimento[indice];
                // atribuicoes e faturar
                novo_pagto.setCpf(_cpf);
                novo_pagto.setValor(_valor);
                novo_pagto.setCod(_cod);
                novo_pagto.setEstabelecimento(_estabelecimento);
                novo_pagto.faturar();
            }
            AtualizaRelatorio();
        }
        private long LongRandom(long min, long max, Random rand)
        {
            byte[] buf = new byte[8];
            rand.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);
            return (Math.Abs(longRand % (max - min)) + min);
        }
        // butMostraFaturas_Click(object sender, EventArgs e)
        private void AtualizaRelatorio()
        {
            List<string> texto = new List<string>();
            // Alimentacao
            texto.Add("=========================ALIMENTACAO=========================\n");
            for(int i = 0; i < 3; i++)
            {
                if (pagtosAliment[i] == null)
                    break;
                texto.Add("CPF: " + Convert.ToString(pagtosAliment[i].getCpf()) );
                texto.Add("Valor bruto: " + Convert.ToString(pagtosAliment[i].getValor()) );
                texto.Add("Codigo: " + Convert.ToString(pagtosAliment[i].getCod()) );
                texto.Add("Descricao: " + pagtosAliment[i].getDescricao() );
                texto.Add("Valor total: " + Convert.ToString(pagtosAliment[i].getVlFatAliment()));
                texto.Add("------------------------------------------------------------------------------------");
            }
            // Saude
            texto.Add("============================SAUDE============================\n");
            for(int i = 0; i < 3; i++)
            {
                if (pagtosSaude[i] == null)
                    break;
                texto.Add("CPF: " + Convert.ToString(pagtosSaude[i].getCpf()));
                texto.Add("Valor bruto: " + Convert.ToString(pagtosSaude[i].getValor()));
                texto.Add("Codigo: " + Convert.ToString(pagtosSaude[i].getCod()));
                texto.Add("Estabelecimento: " + pagtosSaude[i].getEstabelecimento());
                texto.Add("Valor total: " + Convert.ToString(pagtosSaude[i].getVlFatSaude()));
                texto.Add("------------------------------------------------------------------------------------");
            }              
            rtxRelatorio.Lines = texto.ToArray();
        }

        private void butDeletaFaturas_Click(object sender, EventArgs e)
        {
            Array.Clear(pagtosAliment, 0,3);
            Array.Clear(pagtosSaude, 0,3);
            AtualizaRelatorio();
        }
    }
}
