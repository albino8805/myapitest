using MyAPITest.Models;
using MyAPITest.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPITest.Repository
{
    /// <summary>
    /// Base Repository
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    /// <seealso cref="MyAPITest.Repository.Interfaces.IBaseRepository{TEntity}" />
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly APIContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRepository{TEntity}"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public BaseRepository(APIContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        public List<TEntity> Get()
        {
            return _context.Set<TEntity>().ToList();
        }
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }
        /// <summary>
        /// Posts the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public int Post(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);

            return _context.SaveChanges();
        }
        /// <summary>
        /// Patches the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Patch(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);

            _context.SaveChanges();
        }
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(int id)
        {
            var toRemove = _context.Set<TEntity>().Find(id);
            _context.Set<TEntity>().Remove(toRemove);

            _context.SaveChanges();
        }
    }
}
