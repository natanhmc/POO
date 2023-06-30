using System.Linq.Expressions;
using aula18_AS.Data.Context;
using aula18_AS.Domain.Entities;
using aula18_AS.Domain.Interfaces.RepositoryInterfaces;


namespace aula18_AS.Data.Repositories
{
    public class EmprestimoRepository : IEmprestimoRepository
    {
        private readonly DataContext _context;
        public EmprestimoRepository(DataContext dbContext)
        {
            _context = dbContext;
        }
        public void Save(Emprestimo entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
               
        }
        public bool Delete(int entityId)
        {
            Emprestimo emprestimo = GetById(entityId);
            if (emprestimo != null)
            {
                _context.Remove(emprestimo);
                _context.SaveChanges();
                return true ;
            }
            else
            {
                return false;
            }
        }
        public IList<Emprestimo> GetAll()
        {
            return _context.Set<Emprestimo>().ToList();
        }

        public Emprestimo GetById(int entityId)
        {
            return _context.Set<Emprestimo>().Find(entityId);
        }


        public IList<Emprestimo> SearchAll(Expression<Func<Emprestimo, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(Emprestimo entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }
    }
}