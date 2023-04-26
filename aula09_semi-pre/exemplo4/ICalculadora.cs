using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula09_semi_pre.exemplo4
{
    public interface ICalculadora
    {
        public void Somar(int num1, int num2);
        public void Diminuir(int num1, int num2);
        public void Multiplicar(int num1, int num2);
        public void Dividir(int num1, int num2);
    }
}