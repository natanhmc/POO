using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula02_exercicios
{
    public class ContaBancaria
    {
        public double Saldo {get;private set;}
        public double Numero{get;private set;}

        public ContaBancaria(int numero, double saldoInicial) 
        {
            Numero = numero;
            Saldo = saldoInicial;
        }

        public double Depositar(double valor)
        {
            Saldo = Saldo + valor;
            return Saldo;
        }
        public double Sacar(double valor)
        {
            if(valor > Saldo){
                Console.WriteLine("saldo insuficiente");
            }else{
                Saldo = Saldo- valor;
            }
            return Saldo;

        }
        public void Estrato()
        {
            Console.WriteLine("seu saldo é de "+Saldo);
        }
    }
}