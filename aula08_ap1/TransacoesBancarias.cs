using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula08_ap1
{
    public class TransacoesBancarias : ContaCorrente
    {
        public Cliente cliente { get;set; }
        
        public TransacoesBancarias( Cliente cliente){
            this.cliente=cliente;
        }
        
        public string Saldacao(){
            return ("Seja muito bem vindo cliente " + cliente.Nome);

        }
    }
}