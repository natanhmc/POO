using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula09_semi_pre.exemplo4
{
    public class Calculadora : ICalculadora
    {
        public void Somar(int num1, int num2){
            int soma = num1 + num2;
            Mostrar(soma.ToString());
        }
        public void Diminuir(int num1, int num2){
            int resto = num1 - num2;
            Mostrar(resto.ToString());
        }
        public void Dividir(int num1, int num2){
            int result = num1 / num2;
            Mostrar(result.ToString());
        }
        public void Multiplicar(int num1, int num2){
            int mult = num1 * num2;
            Mostrar(mult.ToString());
        }


        public void Mostrar(string msg){
            Console.WriteLine(msg);
        }

    }
}