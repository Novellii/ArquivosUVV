using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapoxa.Classes
{
    internal class Capivaras
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public float peso { get; set; }
        public Capivaras(string nome, int idade, float peso)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
        }
    }
}
