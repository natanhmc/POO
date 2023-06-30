using aula18_AS.Data.Context;
using aula18_AS.Domain.Entities;
using aula18_AS.Domain.Interfaces.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace aula18_AS.Data.Repositories
{
    public class UsuarioRepository : IUsuariosRepository
    {
        private readonly DataContext _context;
        public UsuarioRepository(DataContext dbContext)
        {
            _context = dbContext;
        }
         public void Save(Usuario entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Usuario entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public bool Delete(int entityId)
        {
            Usuario usuario = GetById(entityId);
            if (usuario != null)
            {
                _context.Remove(usuario);
                _context.SaveChanges();
                return true ;
            }
            else
            {
                return false;
            }
        }

        public IList<Usuario> GetAll()
        {
            return _context.Set<Usuario>().Include(u => u.Emprestimo).ToList();
        }

        public Usuario GetById(int entityId)
        {
            return _context.Set<Usuario>().Find(entityId);
        }

        public List<Livro> LivrosEmprestados(int usuarioId)
        {
            // Usuario usuario = _context.Set<Usuario>()
            //     .Include(u => u.Emprestimo)
            //     .ThenInclude(e => e.Emprestimos)
            //     .FirstOrDefault(u => u.Id == usuarioId);

            // if (usuario != null)
            // {
            //     List<Livro> livrosEmprestados = usuario.Emprestimo
            //         .Select(e => e.Emprestimos)
            //         .ToList();

            //     return livrosEmprestados;
            // }

            return new List<Livro>();
        }

        public void Dispose()
        {
            
        }
    }
}