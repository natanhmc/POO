using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula12_entity_frework.Domain.Interfaces;
using aula12_entity_frework.Data;
using aula12_entity_frework.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace aula12_entity_frework.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DataContext context;
        public PersonRepository(DataContext context)
        {
            this.context = context;
        }

        public IList<Person> GetAll()
        {
            return context.People.Include(x=>x.City).ToList();
        }

        public void Save(Person entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public bool Delete(int entityId)
        {
            var person = GetById(entityId);
            context.Remove(person);
            context.SaveChanges();
            return true;
        }
        
        public Person GetById(int entityId)
        {
            return context.People.SingleOrDefault(x=>x.Id == entityId);
        }

        public void Update(Person entity)
        {
            context.City = context.Find();
            context.People.Update(entity);
            context.SaveChanges();
        
        }
    }
}