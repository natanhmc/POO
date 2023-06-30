using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula15_Ap2.Domain.Entities;
using aula15_Ap2.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace aula15_Ap2.Data.Repository
{
    public class GerenteCliRepository : IGerenteCliRepository
    {
        private readonly DataContext context;
        public GerenteCliRepository()
        {
            this.context = new DataContext();
        }

        public void Save(Cliente entity)
        {
            entity.Enderecos = context.Enderecos.Find(entity.Enderecos.Id);
            context.Add(entity);
            context.SaveChanges();
        }
     
        public bool Delete(int entityId)
        {
            var client = GetById(entityId);
            context.Cliente.Remove(client);
            context.SaveChanges();
            return true;
        }

        public Cliente GetById(int entityId)
        {
            return context.Cliente.Include(x=>x.Enderecos).SingleOrDefault(x=>x.Id == entityId);
    
        }

        public IList<Cliente> GetAll()
        {
            return context.Cliente.Include(x=>x.Enderecos).ToList();
        }

        public void Update(Cliente entity)
        {
            entity.Enderecos = context.Enderecos.SingleOrDefault(x=>x.Id == entity.Enderecos.Id);
            context.Cliente.Update(entity);
            context.SaveChanges();
        }
    }

    //   ainda não consegui fazer funcionar o update, creio que tenha que passar o id por parâmetro e dar um getbyid para achar o cliente e depois fazer o update
}