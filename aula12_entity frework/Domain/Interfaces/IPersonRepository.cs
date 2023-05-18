using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula12_entity_frework.Domain.Entities;

namespace aula12_entity_frework.Domain.Interfaces
{
    public interface IPersonRepository : IBaseRepository<Person>
    {
        
    }
}