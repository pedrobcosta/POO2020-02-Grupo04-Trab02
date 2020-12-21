using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaTrabalho02Projeto01
{
    class Saude : Pagamento
    {
        // atributos
        string estabelecimento;
        double vlFatSaude;
        // construtores
        public Saude() : base()
        {
            estabelecimento = "default";
            vlFatSaude = 0.00;
        }
        // metodos
        public override void faturar()
        {
            double _vlFatSaude = valor * 1.12;
            setVlFatSaude(_vlFatSaude);
        }
        public string getEstabelecimento()
        {
            return estabelecimento;
        }
        public double getVlFatSaude()
        {
            return vlFatSaude;
        }
        public void setEstabelecimento(string _estabelecimento)
        {
            estabelecimento = _estabelecimento;
        }
        public void setVlFatSaude(double _vlFatSaude)
        {
            vlFatSaude = _vlFatSaude;
        }
    }
}
