using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula08_ap1
{
    public class Enderecos
    {
        public string Rua {get; set;}
        public string Bairro { get; set; }

        public Enderecos(string rua, string bairro){
            Rua = rua;
            Bairro = bairro;
        }
    }
}