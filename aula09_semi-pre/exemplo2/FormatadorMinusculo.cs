using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula09_semi_pre.exemplo2
{
    public class FormatadorMinusculo : IFortadorTexto
    {
        public void FormatarTexto(string texto){
            string textoMinusculo = texto.ToLower();
            Mostrar(texto);
        }

        public void Mostrar(string texto){
            Console.WriteLine(texto);
        }
    }
}