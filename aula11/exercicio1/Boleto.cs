using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula11.exercicio1
{
    public class Boleto : IPagamento
    {
        public void Pagar(double valor){
            Console.WriteLine("forma de pagamento Boleto no valor de "+ valor);
        }
    }
}