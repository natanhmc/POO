using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula15_Ap2.Domain.Entities;
using aula15_Ap2.Domain.Intefaces;

namespace aula15_Ap2.Data.Repository
{
    public class TransacoesRepository : IContaCorrente
    {
        private readonly DataContext context;
        public TransacoesRepository()
        {
            this.context = new DataContext();
        }
        public double Saque(int _id, double valor)
        {
            var _cliente = context.Cliente.SingleOrDefault(x => x.Id == _id);
            _cliente.Saldo -= valor;
            context.SaveChanges();
            return _cliente.Saldo;

        }
        public double Deposito(int _id, double valor)
        {
            var _cliente = context.Cliente.SingleOrDefault(x => x.Id == _id);
            _cliente.Saldo += valor;
            context.SaveChanges();
            return _cliente.Saldo;
        }
        
        public void Save(TransacoesBancarias entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }


        public TransacoesBancarias GetById(int entityId)
        {
            throw new NotImplementedException();
        }

        public IList<TransacoesBancarias> GetAll()
        {
            throw new NotImplementedException();
        }


        public bool Delete(int entityId)
        {
            throw new NotImplementedException();
        }

        public void Update(TransacoesBancarias entity)
        {
            throw new NotImplementedException();
        }
    }
}