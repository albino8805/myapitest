using MyAPITest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPITest.Repository.Interfaces
{
    /// <summary>
    /// IUser
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        List<User> Get();
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        User GetById(int id);
        /// <summary>
        /// Posts the specified entity.
        /// </summary>
        /// <param name="user">The entity.</param>
        /// <returns></returns>
        int Post(User user);
        /// <summary>
        /// Patches the specified entity.
        /// </summary>
        /// <param name="user">The entity.</param>
        void Patch(User user);
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        void Delete(int id);
    }
}
