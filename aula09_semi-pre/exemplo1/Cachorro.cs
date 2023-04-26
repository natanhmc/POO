using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula09_semi_pre.exemplo1
{
    public class Cachorro : IAnimal
    {
        public void EmitirSom(){
            Mostrar("AU! AU!");
        }
        
        public void Mostrar(string texto){
            Console.WriteLine(texto);
        }
    }
}