using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula18_AS.Data.Context;
using aula18_AS.Domain.Interfaces.RepositoryInterfaces;

namespace aula18_AS.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }

        Task IUnitOfWork.Commit()
        {
            throw new NotImplementedException();
        }

        private IUsuariosRepository _UsuarioRepository;

        private ILivroRepository _LivroRepository;

        private IAutorRepository _AutorRepository;

        public IUsuariosRepository FornecedorRepository
        {
            get { return _UsuarioRepository ??= new UsuarioRepository(_context); }
        }

        public ILivroRepository ProdutoRepository
        {
            get { return _LivroRepository ??= new LivroRepository(_context); }
        }

        public IAutorRepository AutorRepository
        {
            get { return _AutorRepository ??= new AutorRepository(_context); }
        }

        IAutorRepository IUnitOfWork.AutorRepository => throw new NotImplementedException();

        IUsuariosRepository IUnitOfWork.UsuarioRepository => throw new NotImplementedException();

        ILivroRepository IUnitOfWork.LivroRepository => throw new NotImplementedException();
    }
    
}