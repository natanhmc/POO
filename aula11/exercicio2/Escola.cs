using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula11.exercicio2
{
    public class Escola
    {
        public void ApresentarPessoa(IPessoa pessoa){
            pessoa.Falar("ola eu sou " + pessoa.Nome);
        }
    }
}