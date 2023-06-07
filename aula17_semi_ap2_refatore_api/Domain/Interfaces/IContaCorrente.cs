using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula15_Ap2.Domain.Entities;
using aula15_Ap2.Domain.Interfaces;

namespace aula15_Ap2.Domain.Intefaces
{
    public interface IContaCorrente : IBaseRepository<TransacoesBancarias>
    {
        public double Deposito(int _id, double valor);

        public double Saque(int _id, double valor);

        
    }
}