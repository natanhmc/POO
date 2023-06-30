// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
using aula18_AS.Domain.Entities;

namespace aula18_AS.Domain.Interfaces.RepositoryInterfaces
{
    public interface ILivroRepository : IBaseRepository<Livro>
    {
        List<Livro> LivrosPorAutor(int autorId);
    }
}