using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaBanco
{
    internal class Fila
    {
        private Cliente Head { get; set;  }
        private Cliente Tail { get; set; }

        public Fila()
        {
            Head = null;
            Tail = Head;
        }
        public bool Vazia()
        {
            if (this.Tail == null && this.Head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Enfileirar(Cliente c)
        {
            if (Vazia())
            {
                this.Head = c;
                this.Tail = c;
            }
            else
            {
                this.Tail.Proximo = c;
                this.Tail = c;
            }
        }

        public Cliente Desenfileirar()
        {
            if (Vazia())
            {
                Console.WriteLine("Fila Vazia");
                return null;
            }
            else
            {
                //Console.WriteLine($"Chamando {Head.Nome} da fila");
                Cliente aux = Head;
                this.Head = this.Head.Proximo;
                if (this.Head == null)
                {
                    this.Tail = null;
                }
                return aux;
            }
        }
        public void MostrarFila()
        {
            if (Vazia())
            {
                Console.WriteLine("Fila Vazia");
            }
            else
            {
                Console.WriteLine("Pessoas na fila: ");
                Cliente aux = this.Head;
                while (aux != null)
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                }
            }
        }
    }
}
