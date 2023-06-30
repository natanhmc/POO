using System.Linq.Expressions;
using aula18_AS.Data.Context;
using aula18_AS.Domain.Entities;
using aula18_AS.Domain.Interfaces.RepositoryInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace aula18_AS.Data.Repositories
{
    public class AutorRepository : IAutorRepository
    {
        private readonly DataContext _context;
        public AutorRepository(DataContext dbContext)
        {
            _context = dbContext;
        }
        public void Save(Autor entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }
        public bool Delete(int entityId)
        {
            Autor autor = GetById(entityId);
            if (autor != null)
            {
                _context.Remove(autor);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }


        public IList<Autor> GetAll()
        {
            return _context.Set<Autor>().ToList();
        }



        public Autor GetById(int entityId)
        {
            return _context.Set<Autor>().Find(entityId);
        }



        public IList<Autor> SearchAll(Expression<Func<Autor, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(Autor entity)
        {
            throw new NotImplementedException();
        }


        public void Dispose()
        {
        }

    }
}