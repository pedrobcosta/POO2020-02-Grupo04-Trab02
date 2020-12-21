using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaTrab02Projeto02
{
    class Container
    {
        // atributos
        private string codigo;
        private Container proxContainer;
        public override string ToString()
        {
            return this.codigo;
        }
        // metodos
        public Container()
        {
            codigo = "";
            proxContainer = null;
        }

        public Container(string _codigo)
        {
            codigo = _codigo;
            proxContainer = null;
        }

        public Container(string _codigo, Container _proxContainer)
        {
            codigo = _codigo;
            proxContainer = _proxContainer;
        }
        // getters
        public string getCodigo()
        {
            return codigo;
        }

        public Container getProx()
        {
            return proxContainer;
        }
        // setters
        public void setCodigo(string _codigo)
        {
            codigo = _codigo;
        }
        public void setProx(Container novoContainer)
        {
            proxContainer = novoContainer;
        }
    }
}
