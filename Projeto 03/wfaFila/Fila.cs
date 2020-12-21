using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaFila
{
    class Fila
    {
        //Atributos
        public NohFila start;
        public NohFila end;

        //Métodos
        //construtor default
        public Fila()
        {
            start = null;
            end = null;
        }

        //função para verificar se esta vazia
        public bool isEmpty()
        {
            if (start == null)
                return true;
            else
                return false;

        }

        public void inserir(int data)
        {
            NohFila novoNoh = new NohFila(data);

            if (isEmpty())
            {
                start = end = novoNoh;
            }

            else
            {
                end.setNext(novoNoh);
                novoNoh.setPrev(end);
                end = novoNoh;
            }

        }// Fim da função inserir

        public NohFila achaNoh(int data)
        {
            NohFila temp = start;

            while (temp != end)
            {
                if (temp.getData().Equals(data))
                    break;
                else
                    temp = temp.getNext();
            }
            if (temp == null)
                return null;
            else if ((temp == end && !(temp.getData().Equals(data))))
                return null;
            else
                return temp;
        }
        public void remove(int data)
        {
            NohFila temp = achaNoh(data);

            if (isEmpty())
            {
                return;
            }

            else if (temp == null)
            {
                return;
            }
            else if (temp == start && temp == end)
            {
                start = end = null;
            }

            else if (temp == start)
            {
                start = start.getNext();
                start.setPrev(null);
            }

            else if (temp == end)
            {
                end = end.getPrev();
                end.setNext(null);
            }
            else
            {
                temp.getPrev().setNext(temp.getNext());
                temp.getNext().setPrev(temp.getPrev());
            }
        }

        public void inserirdps(int data, int depois) //Para a letra C
        {
            NohFila temp = achaNoh(depois);
            NohFila newnoh = new NohFila(data);

            if (isEmpty())
            {
                start = end = newnoh;
            }
            else if (temp.getNext() == null)
            {
                newnoh.setPrev(temp);
                newnoh.setNext(null);
                temp.setNext(newnoh);
            }
            else
            {
                newnoh.setPrev(temp);
                newnoh.setNext(temp.getNext());
                temp.setNext(newnoh);
                newnoh.getNext().setPrev(newnoh);
            }
        }

    }
}

