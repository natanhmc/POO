using System.Linq.Expressions;
using aula18_AS.Data.Context;
using aula18_AS.Domain.Entities;
using aula18_AS.Domain.Interfaces.RepositoryInterfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace aula18_AS.Data.Repositories
{
    public class LivroRepository : ILivroRepository
    {
    private readonly DataContext _context;

        public LivroRepository(DataContext context)
        {
            _context = context;
        }
        public void Save(Livro entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }
        public IList<Livro> GetAll()
        {
            return _context.Set<Livro>().Include(i => i.LivrosAutores).ToList();
        }

        public bool Delete(int entityId)
        {
            Livro livro = GetById(entityId);
            if (livro != null)
            {
                _context.Remove(livro);
                _context.SaveChanges();
                return true ;
            }
            else
            {
                return false;
            }
        }

        public Livro GetById(int entityId)
        {
            return _context.Set<Livro>().Find(entityId);
        }

        public List<Livro> LivrosPorAutor(int autorId)
        {
            throw new NotImplementedException();
        }
        public IList<Livro> SearchAll(Expression<Func<Livro, bool>> predicate)
        {
            throw new NotImplementedException();
        }
        public void Update(Livro entity)
        {
            throw new NotImplementedException();
        }


        public void Dispose()
        {
        
        }
    }
}