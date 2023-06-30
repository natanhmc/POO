// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Linq.Expressions;
// using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace aula18_AS.Domain.Interfaces.RepositoryInterfaces
{
    public interface IBaseRepository<Entity> : IDisposable where Entity : class
    {
        //  IList<Entity> SearchAll(Expression<Func<Entity, bool>> predicate);
         Entity GetById(int entityId);
         IList<Entity> GetAll();
         void Save(Entity entity);
         bool Delete(int entityId);
         void Update(Entity entity);
    }
}