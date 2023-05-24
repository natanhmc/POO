using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula15_Ap2.Domain.Entities;
using aula15_Ap2.Domain.Interfaces;

namespace aula15_Ap2.Data.Repository
{
    public class GerenteCliRepository : IGerenteCliRepository
    {
        private readonly DataContext context;
        public GerenteCliRepository(DataContext context)
        {
            this.context = context;
        }

        public void Save(Cliente entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }
     
        public bool Delete(int entityId)
        {
            var client = GetById(entityId);
            context.Remove(client);
            context.SaveChanges();
            return true;
        }

        public Cliente GetById(int entityId)
        {
            return context.Cliente.SingleOrDefault(x=>x.Id == entityId);
        }

        public IList<Cliente> GetAll()
        {
            return context.Cliente.ToList();
        }

        public void Update(Cliente entity)
        {
            context.Cliente.Update(entity);
            context.SaveChanges();
        }
    }
}