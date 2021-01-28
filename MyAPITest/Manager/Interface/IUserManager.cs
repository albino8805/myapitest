using MyAPITest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPITest.Manager.Interface
{
    /// <summary>
    /// IUserManager
    /// </summary>
    public interface IUserManager
    {
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        List<UserViewModel> Get();
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        UserViewModel GetById(int id);
        /// <summary>
        /// Posts the specified entity.
        /// </summary>
        /// <param name="model">The entity.</param>
        /// <returns></returns>
        int Post(UserViewModel model);
        /// <summary>
        /// Patches the specified entity.
        /// </summary>
        /// <param name="model">The entity.</param>
        void Patch(int id, UserViewModel model);
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        void Delete(int id);
    }
}
