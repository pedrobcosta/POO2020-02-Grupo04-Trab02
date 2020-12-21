using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaTrabalho02Projeto01
{
    class Pagamento
    {
        // atributos
        protected long cpf;
        protected double valor;
        protected int cod;
        // construtores
        public Pagamento()
        {
            cpf = 10000000000;
            valor = 0.00;
            cod = 0;
        }
        // metodos
        public virtual void faturar() { }

        public long getCpf()
        {
            return cpf;
        }
        public int getCod()
        {
            return cod;
        }
        public double getValor()
        {
            return valor;
        }
        public void setCpf(long _cpf)
        {
            cpf = _cpf;
        }
        public void setCod(int _cod)
        {
            cod = _cod;
        }
        public void setValor(double _valor)
        {
            valor = _valor;
        }
    }
}
