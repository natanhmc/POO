using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_06
{
    public class PessoaFisica : Pessoa
    {
        public PessoaFisica(int id, string nome, Cidade cidade, string CPF)
         : base(id, nome, cidade)
        {
            this.CPF=CPF;
        }

        public string CPF { get; set; }
    }
}