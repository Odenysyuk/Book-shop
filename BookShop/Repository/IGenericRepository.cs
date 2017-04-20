using System;
using System.Linq;
using System.Linq.Expressions;

namespace BookShop.Repository
{
    /// <summary>
    ///     Generic repository interface creating database access abstraction layer.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IGenericRepository<TEntity>
    {
        /// <summary>
        /// Get entity into dataa base
        /// </summary>
        /// <param name="filter"> Get entity by filter</param>
        /// <param name="orderBy">Get entity and order it</param>
        /// <param name="includeProperties">Include property</param>
        /// <returns></returns>
        IQueryable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            Expression<Func<TEntity, object>>[] includeProperties = null);

        TEntity GetById(object id);

        /// <summary>
        ///     Insert entity into database.
        /// </summary>
        /// <param name="entity"></param>
        void Insert(TEntity entity);

        /// <summary>
        ///     Updat an entity.
        /// </summary>
        /// <param name="entityToUpdate"></param>
        void Update(TEntity entityToUpdate);

        /// <summary>
        ///     Delete an entity based on its ID.
        /// </summary>
        /// <param name="id">ID-object of the entity.</param>
        void Delete(object id);

        /// <summary>
        ///     Delete the entity.
        /// </summary>
        /// <param name="entityToDelete">Entity to delete.</param>
        void Delete(TEntity entityToDelete);
    }
}
