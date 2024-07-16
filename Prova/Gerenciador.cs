using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    public class Gerenciador
    {
        public List<PessoaFisica> PessoasFisica { get; set; }
        public List<PessoaJuridica> PessoasJuridica { get; set; }
        public Gerenciador()
        {
            PessoasFisica = new List<PessoaFisica>();
            PessoasJuridica = new List<PessoaJuridica>();
        }

        public void AdicionarPessoaFisica(PessoaFisica pf)
        {
            if(pf.ValidarCpf() == true)
            {
                PessoasFisica.Add(pf);
            }
            else
            {
                Console.WriteLine("Cpf Inválido");
            }
        }
        public void AdicionarPessoaJuridica(PessoaJuridica pj)
        {
            if(pj.ValidarCnpj() == true)
            {
                PessoasJuridica.Add(pj);
            }
            else
            {
                Console.WriteLine("Cnpj Inválido");
            }
        }
    }
}
