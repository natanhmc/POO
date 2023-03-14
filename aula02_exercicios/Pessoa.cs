using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula02_exercicios
{
    public class Pessoa
    {
        public string Nome { get;set;} = "";

        public int Idade {get;set;}

        public string Apresentar(){
            return "Ola "+ Nome +", voce tem "+ Idade +" anos.";
        }
    }
}