using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleWork3ClassNodo
{
    class Lista
    {
        private Nodo head;

        public  Nodo Head
        {
            get
            {
                return head;
            }
            set
            {
                head = value;
            }
        }
        public Lista()
        {
            head = null;
        }

        //Operaciones
        //Agregar

        public void Agregar(Nodo n)
        {
            //Lista esta vacia 
            if (head == null)
            {
                head = n;
                return;
            }
            //No esta vacio
            if (n.Numero < head.Numero)
            {
                //al inicio
                n.Siguiente = head;
                head = n;
                return;
            }
            Nodo h = head;
            while (h.Siguiente != null)
            {
                if (n.Dato > h.Siguiente.Dato)
                {
                    break;
                }
                h = h.Siguiente;
            }
            n.Siguiente = h.Siguiente;
            h.Siguiente = n;
        }

        public void Eliminar(int d)
        {
            //Revisar que la lista NO este vacia!!!
            if (head == null)
            {
                return;
            }
            //Si el nodo a eliminar es el primero (head)
            if (head.Numero == d)
            {
                head = head.Siguiente;
                return;
            }
            Nodo h = head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Numero == d)
                {
                    break;
                }
                h = h.Siguiente;
            }
            if (h.Siguiente != null)
            {
                h.Siguiente = h.Siguiente.Siguiente;
            }
        }
        public bool Buscar(int d)
        {
            //Revisar que la lista NO este vacia!!!
            if (head == null)
            {
                return false;
            }
            //Si el nodo a eliminar es el primero (head)
            if (head.Numero == d)
            {
                head = head.Siguiente;
                return true;
            }
            Nodo h = head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Numero == d)
                {
                    return true;
                }
                h = h.Siguiente;
            }
            return false;
        }
        public void Mostrar (ListBox lista)
        {
            Nodo h = head;
            lista.Items.Clear;
            while (h != null)
            {
                lista.Items.Add(h.ToString());
                h = h.Siguiente;
            }
        }
        public override string ToString()
        {
            string listaEnTexto = "";
            Nodo h = head;
            while (h != null)
            {
                listaEnTexto += h.ToString() + " ";
                h = h.Siguiente;
            }
            return listaEnTexto;
        }
    }
}
