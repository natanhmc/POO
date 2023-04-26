using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula09_semi_pre.exemplo2
{
    public class FormatadorInverso : IFortadorTexto
    {
        public void FormatarTexto(string texto){
            char[] inverso = texto.ToCharArray();
            Array.Reverse(inverso);
            Mostrar(string.Concat(inverso));
        }

        public void Mostrar(string texto){
            Console.WriteLine(texto);
        }
    }
}