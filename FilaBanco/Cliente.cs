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

        public Cliente(string nome, int idade, bool ehPrioritario)
        {
            Nome = nome;
            Idade = idade;
            EhPrioritario = ehPrioritario;
        }

        public override string ToString()
        {
            return $"{Nome} (Idade: {Idade}, {(EhPrioritario ? "Prioritário" : 
                "Normal")})";
        }
    }
}
