using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula09_semi_pre.exemplo1
{
    public class Papagaio : IAnimal
    {
        public void EmitirSom(){
            Mostrar("OLA OLA");
        }
        public void Mostrar(string texto){
            Console.WriteLine(texto);
        }
    }
}