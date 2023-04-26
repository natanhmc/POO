using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula09_semi_pre.exemplo3
{
    public class Dono
    {
        public string Nome { get;private set; } = "";
        public string endereco { get; set; }  = "";  

        public Dono(string nome){
            this.Nome = nome;
        }
    }
}