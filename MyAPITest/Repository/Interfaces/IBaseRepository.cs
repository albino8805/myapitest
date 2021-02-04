using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPITest.Repository.Interfaces
{
    /// <summary>
    /// Base Repository
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public interface IBaseRepository<TEntity>
    {
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        List<TEntity> Get();
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        TEntity GetById(int id);
        /// <summary>
        /// Posts the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        int Post(TEntity entity);
        /// <summary>
        /// Patches the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Patch(TEntity entity);
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        void Delete(int id);
    }
}
