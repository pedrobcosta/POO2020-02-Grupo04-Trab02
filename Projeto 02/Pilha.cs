using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaTrab02Projeto02
{
    class Pilha
    {
        // atributos
        private int id;
        private Container topo;
        private int num_container;
        public override string ToString()
        {
            return "Pilha " + id;
        }
        // getters
        public Container getTopo()
        {
            return topo;
        }
        public int getNum_container()
        {
            return num_container;
        }
        public int getId()
        {
            return id;
        }
        // setters
        public void setNum_container(int _containeres)
        {
            num_container = _containeres;
        }
        public void setId(int _id)
        {
            id = _id;
        }
        // metodos
        public Pilha()
        {
            topo = null;
            num_container = 0;
            id = 0;
        }
        public Pilha(int _id)
        {
            topo = null;
            num_container = 0;
            id = _id;
        }
        public bool isEmpty()
        {
            if (topo == null)
                return true;
            else
                return false;
        }
        public void push(string _codigo)
        {
            Container novoContainer = new Container(_codigo,topo);
            topo = novoContainer;
            setNum_container(getNum_container() + 1);
        }
        public string pop()
        {
            if (isEmpty())
            {
                return ("Pilha vazia\nImpossível remover container");
            }
            else
            {
                string _codigo = topo.getCodigo();
                topo = topo.getProx();
                setNum_container(getNum_container() - 1);
                return (_codigo);
            }
        }
    }
}
