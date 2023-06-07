using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula15_Ap2.Domain.Intefaces;

namespace aula15_Ap2.Domain.Entities
{
    public class TransacoesBancarias 
    {
        public int Id { get; set; }
        public Cliente cliente { get;set; }

        public string Operacao { get; set; }

        public double Valor { get; set; }  
        public DateTime Data { get; }
        public TransacoesBancarias(){
            Data = DateTime.Now;
        }
    }
}