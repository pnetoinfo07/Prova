using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        private string Nacionalidade { get; set; }
        public double Peso { get; set; }
        public Pessoa(string Nome, int Idade, string Nacionalidade, double Peso)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Nacionalidade = Nacionalidade;
            this.Peso = Peso;
        }
    }
}
