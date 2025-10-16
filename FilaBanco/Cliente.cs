using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaBanco
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public bool EhPrioritario { get; set; }

        public Cliente Proximo { get; set; }

        public Cliente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            this.Proximo = null;
            if(this.Idade > 59)
            {
                EhPrioritario = true;
            }
            else
            {
                EhPrioritario = false;
            }
            //EhPrioritario = ehPrioritario;
        }

        public override string ToString()
        {
            return $"{Nome} \nIdade: {Idade} \nPrioritário: " + (this.EhPrioritario ?
                "Sim" : "Não");
        }
    }
}
