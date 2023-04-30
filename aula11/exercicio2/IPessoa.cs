using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula11.exercicio2
{
    public interface IPessoa
    {
        string Nome { get;}
        int Idade {get;}

        void Falar(string texto);

    }
}