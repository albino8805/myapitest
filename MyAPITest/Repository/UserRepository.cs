using MyAPITest.Models;
using MyAPITest.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPITest.Repository
{
    /// <summary>
    /// UserRepository
    /// </summary>
    /// <seealso cref="MyAPITest.Repository.Interfaces.IUserRepository" />
    public class UserRepository: IUserRepository
    {
        private readonly APIContext _context;
        private bool ActiveFalse = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public UserRepository(APIContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        public List<User> Get()
        {
            return _context.User.ToList();
        }
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public User GetById(int id)
        {
            return _context.User.Where(p => p.Id == id).FirstOrDefault();
        }
        /// <summary>
        /// Posts the specified entity.
        /// </summary>
        /// <param name="user">The entity.</param>
        /// <returns></returns>
        public int Post(User user)
        {
            _context.User.Add(user);

            return _context.SaveChanges();
        }
        /// <summary>
        /// Patches the specified entity.
        /// </summary>
        /// <param name="user">The entity.</param>
        public void Patch(User user)
        {
            var entity = GetById(user.Id);

            entity.Name = user.Name;
            entity.Age = user.Age;
            entity.UpdatedAt = user.UpdatedAt;

            _context.SaveChanges();
        }
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(int id)
        {
            var entity = GetById(id);

            entity.Active = ActiveFalse;
            entity.UpdatedAt = DateTime.Now;

            _context.SaveChanges();
        }
    }
}
