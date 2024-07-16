using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    public class PessoaJuridica:Pessoa
    {
        public string Cnpj { get; set; }

        public PessoaJuridica(string Nome, int Idade, string Nacionalidade, double Peso, string Cnpj)
            :base(Nome,Idade,Nacionalidade,Peso)
        {
            this.Cnpj = Cnpj;
        }
        public bool ValidarCnpj()
        {
            if(Cnpj.Length == 14)
            {
                return true;
            }
            return false;
        }
    }
}
