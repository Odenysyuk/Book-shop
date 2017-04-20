using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using BookShop.Model;

namespace BookShop.Repository
{
    class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected BookShopContext context;
        protected DbSet<TEntity> DbSet;

        public GenericRepository(BookShopContext context) 
        {
            this.context = context;
            DbSet = context.Set<TEntity>();
        }

        public virtual IQueryable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            Expression<Func<TEntity, object>>[] includeProperties = null)
        {
            var query = DbSet.AsQueryable();

            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (orderBy != null)
            {
                query = orderBy(query);
            }
            if (includeProperties != null)
            {
                query = includeProperties.Aggregate(query, (x, includeProperty) => x.Include(includeProperty));
            }
            return query;
        }

        public virtual TEntity GetById(object id)
        {
            return DbSet.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            DbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }

        public virtual void Delete(object id)
        {
            TEntity entityToDelete = DbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                DbSet.Attach(entityToDelete);
            }
            DbSet.Remove(entityToDelete);
        }
    }
}
