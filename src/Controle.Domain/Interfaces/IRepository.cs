using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using Controle.Domain.Core.Models;

namespace Controle.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity<TEntity>
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(int id);
        TEntity FindById(int id);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> FindAll();
        int SaveChanges();
    }
}
