using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula11.exercicio1
{
    public class CartaoCredito : IPagamento
    {
        public void Pagar(double valor){
            Console.WriteLine("forma de pagamento Cartao no valor de " + valor);
        }
        
    }
}