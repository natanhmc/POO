using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula09_semi_pre.exemplo5
{
    public class PagamentoBoleto : IServicoPagamento
    {
        public decimal Saldo{get; private set;}

        public PagamentoBoleto(decimal saldo){
            Saldo = saldo;
        }
        public void EfetuarPagamento(decimal valor){
            Mostrar(string.Concat("Seu saldo de boletos era de: ",Saldo));
            Saldo += valor;
            Mostrar(string.Concat("Agora seu saldo é de: ",Saldo));

        }

        public void EstornarPagamento(decimal valor){
            Mostrar(string.Concat("Seu saldo de boletos era de: ",Saldo));
            Saldo -= valor;
            Mostrar(string.Concat("Agora seu saldo é de: ",Saldo));
        }

        public void Mostrar(string msg){
            Console.WriteLine(msg);
        }
    }
}