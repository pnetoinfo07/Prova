using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
        public int TempoServico { get; set; }
        public PessoaFisica(string Nome, int Idade, string Nacionalidade, double Peso, string Cpf)
             : base(Nome, Idade, Nacionalidade, Peso)
        {
            this.Cpf = Cpf;
        }

        public bool ValidarCpf()           
        {
            if(Cpf.Length == 11)
            {
                return true;
            }
            return false;
        }
    }
}
