using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila
{
    public class FilaClass 
    {
        private Pessoa head;
        private Pessoa tail;

        public FilaClass()
        {
            head = null;
            tail = head;
        }

        public bool FilaVazia()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void InserirPessoa(Pessoa elemento)
        {
            if (FilaVazia())
            {                
                head = elemento;
                tail = elemento;
            }
            else
            {
                tail.Proximo = elemento;
                tail = elemento;
            }
            Console.WriteLine($"Pessoa {elemento.Nome} adicionado!");
        }

        public void RemoverPessoa()
        {
            if (FilaVazia())
            {
                Console.WriteLine("Fila Vazia");
            }
            else
            {
                Console.WriteLine($"Removendo {head.Nome} da fila");
                head = head.Proximo;
                if (head == null)
                {
                    tail = null;
                }
            }
        }

        public int TamanhoFila()
        {
            int contador = 0;
            Pessoa aux = head;

            if (FilaVazia())
            {
                return contador;
            }
            else
            {
                aux = head;
                do
                {
                    contador++;
                    aux = aux.Proximo;
                }
                while (aux != null);
            }
            return contador;
        }

        public void ImprimirFila()
        {
            if (FilaVazia())
            {
                Console.WriteLine("Fila Vazia");
            }
            else
            {
                Console.WriteLine("Pessoas na fila: ");
                Pessoa aux = head;
                while (aux != null)
                {
                    Console.WriteLine(aux.Nome);
                    aux = aux.Proximo;
                }
            }
        }
    }
}
