// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
using aula18_AS.Domain.Entities;

namespace aula18_AS.Domain.Interfaces.RepositoryInterfaces
{
    public interface IUsuariosRepository : IBaseRepository<Usuario>
    {
        List<Livro> LivrosEmprestados(int usuarioId);

    }
}