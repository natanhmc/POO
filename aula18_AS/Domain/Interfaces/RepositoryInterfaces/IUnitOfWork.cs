// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

namespace aula18_AS.Domain.Interfaces.RepositoryInterfaces
{
    public interface IUnitOfWork
    {
        Task Commit();

        IAutorRepository AutorRepository {get;}
        IUsuariosRepository UsuarioRepository {get;}
        ILivroRepository LivroRepository {get;}
    }
    
}