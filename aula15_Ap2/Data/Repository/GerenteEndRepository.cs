using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula15_Ap2.Domain.Entities;
using aula15_Ap2.Domain.Interfaces;

namespace aula15_Ap2.Data.Repository
{
    

    public class GerenteEndRepository : IGerenteEndRepository
    {
        private readonly DataContext context;
        public GerenteEndRepository(DataContext context)
        {
            this.context = context;
        }
        public void Save(Enderecos entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }
       
        public bool Delete(int entityId)
        {
            var ender = GetById(entityId);
            context.Remove(ender);
            context.SaveChanges();
            return true;
        }

        public Enderecos GetById(int entityId)
        {
            return context.Enderecos.SingleOrDefault(x=>x.Id == entityId);
        }

        public IList<Enderecos> GetAll()
        {
            return context.Enderecos.ToList();
        }

        public void Update(Enderecos entity)
        {
            context.Enderecos.Update(entity);
            context.SaveChanges();
        }
    }
}
