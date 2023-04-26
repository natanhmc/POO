using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula09_semi_pre.exemplo3
{
    public class Gatto : IAnimalEstimacao
    {
        public string Nome { get; set; } = "";
        public Dono dono { get; set; }

        public Gatto(string nome, Dono dono)
        {
            Nome = nome;
            this.dono = dono;
        }
        
    }
}