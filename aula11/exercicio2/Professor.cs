using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula11.exercicio2
{
    public class Professor : IPessoa
    {
        public string Nome {get; set;}

        public int Idade {get;set ;}

        public Professor(string nome, int idade){
            Nome = nome;
            Idade = idade;
        }
        
        public void Falar(string texto){
            Console.WriteLine(texto);
        }
        
    }
}