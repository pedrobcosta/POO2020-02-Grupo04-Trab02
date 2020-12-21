using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaFila
{
    class NohFila
    {
        //atributos
        private int data;
        private NohFila anterior, prev;

        //métodos
        public NohFila()
        {
            data = 0;
            anterior = null;
        }

        public NohFila(int _data)
        {
            data = _data;
            anterior = null;
        }


        //getters and setters
        public int getData()
        {
            return data;
        }
        public void setData(int n)
        {
            data = n;
        }

        public NohFila getNext()
        {
            return anterior;
        }

        public void setNext(NohFila noh)
        {
            anterior = noh;
        }

        public void setPrev(NohFila noh)
        {
            prev = noh;
        }
        public NohFila getPrev()
        {
            return prev;
        }




    }
}
