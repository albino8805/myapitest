using MyAPITest.Manager.Interface;
using MyAPITest.Models;
using MyAPITest.Repository.Interfaces;
using MyAPITest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPITest.Manager
{
    /// <summary>
    /// UserManager
    /// </summary>
    public class UserManager : IUserManager
    {
        private IUserRepository _repository;

        private const bool Active = true; 

        /// <summary>
        /// Initializes a new instance of the <see cref="UserManager"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public UserManager(IUserRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        public List<UserViewModel> Get()
        {
            var entities = _repository.Get();

            return entities.Select(p => new UserViewModel()
            {
                Id = p.Id,
                Name = p.Name,
                Age = p.Age,
                Active = p.Active
            }).ToList();
        }
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public UserViewModel GetById(int id)
        {
            var entity = _repository.GetById(id);

            return new UserViewModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Age = entity.Age,
                Active = entity.Active
            };
        }
        /// <summary>
        /// Posts the specified entity.
        /// </summary>
        /// <param name="model">The entity.</param>
        /// <returns></returns>
        public int Post(UserViewModel model)
        {
            User entity = new User();

            entity.Name = model.Name;
            entity.Age = model.Age;
            entity.Active = Active;
            entity.CreatedAt = DateTime.Now;

            return _repository.Post(entity);
        }
        /// <summary>
        /// Patches the specified entity.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="model">The entity.</param>
        public void Patch(int id, UserViewModel model)
        {
            User entity = _repository.GetById(id);

            entity.Name = model.Name;
            entity.Age = model.Age;
            entity.UpdatedAt = DateTime.Now;

            _repository.Patch(entity);
        }
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(int id)
        {
          _repository.Delete(id);
        }
    }
}
