using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula11.exercicio1
{
    public class Cliente
    {
       

        public void Comprar(IPagamento forma, double valor){
            forma.Pagar(valor);
        }
    }

    
}