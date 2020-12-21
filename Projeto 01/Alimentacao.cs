using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaTrabalho02Projeto01
{
    class Alimentacao : Pagamento
    {
        // atributos
        private string descricao;
        private double vlFatAliment;
        // construtores
        public Alimentacao() : base()
        {
            descricao = "default";
            vlFatAliment = 0.00;
        }
        // metodos
        public override void faturar()
        {
            double _valFatAlimentacao = Math.Round(1.05 * valor, 2);
            setVlFatAliment(_valFatAlimentacao);
        }
        public string getDescricao()
        {
            return descricao;
        }
        public double getVlFatAliment()
        {
            return vlFatAliment;
        }
        public void setDescricao(string _descricao)
        {
            descricao = _descricao;
        }
        public void setVlFatAliment(double _vlFatAliment)
        {
            vlFatAliment = _vlFatAliment;
        }
    }
}
