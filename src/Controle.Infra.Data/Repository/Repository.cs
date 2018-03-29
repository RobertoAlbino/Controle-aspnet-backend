using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Controle.Domain.Core.Models;
using Controle.Domain.Interfaces;
using Controle.Infra.Data.Context;

namespace Controle.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity<TEntity>
    {
        protected ControleContext DatabaseContext;
        protected DbSet<TEntity> DbSet;

        public Repository(ControleContext context)
        {
            DatabaseContext = context;
            DbSet = DatabaseContext.Set<TEntity>();
        }

        public virtual void Add(TEntity entity)
        {
            DbSet.Add(entity);
            SaveChanges();
        }   

        public virtual void Update(TEntity entity)
        {
            DbSet.Update(entity);
            SaveChanges();
        }

        public virtual void Remove(int id)
        {
            DbSet.Remove(DbSet.Find(id));
            SaveChanges();
        }

        public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.AsNoTracking().Where(predicate);
        }

        public virtual TEntity FindById(int id)
        {
            return DbSet.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public virtual IEnumerable<TEntity> FindAll()
        {
            return DbSet.ToList();
        }

        public int SaveChanges()
        {
            return DatabaseContext.SaveChanges();
        }

        public virtual void Dispose()
        {
            DatabaseContext.Dispose();
        }
    }
}
