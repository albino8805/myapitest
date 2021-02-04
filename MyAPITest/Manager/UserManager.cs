using MyAPITest.Manager.Interface;
using MyAPITest.Models;
using MyAPITest.Repository.Interfaces;
using MyAPITest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyAPITest.Manager
{
    /// <summary>
    /// UserManager
    /// </summary>
    public class UserManager : BaseManager<User, UserViewModel>, IUserManager
    {
        private IUserRepository _repository;

        private const bool Active = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserManager"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public UserManager(IUserRepository repository) : base(repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// Prepares the add data.
        /// </summary>
        /// <param name="viewModel">The view model.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override User PrepareAddData(UserViewModel viewModel)
        {
            return new User() { 
                Name = viewModel.Name,
                Age = viewModel.Age,
                Active = Active,
                CreatedAt = DateTime.Now
            };
        }
        /// <summary>
        /// Prepares the update data.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="viewModel">The view model.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override User PrepareUpdateData(User entity, UserViewModel viewModel)
        {
            entity.Name = viewModel.Name;
            entity.Age = viewModel.Age;
            entity.UpdatedAt = DateTime.Now;

            return entity;
        }
        /// <summary>
        /// Prepares the single return.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override UserViewModel PrepareSingleReturn(User entity)
        {
            return new UserViewModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Age = entity.Age,
                Active = entity.Active,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt
            };
        }
        /// <summary>
        /// Prepares the multiple return.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override List<UserViewModel> PrepareMultipleReturn(List<User> entities)
        {
            return entities.Select(p => new UserViewModel() {
                Id = p.Id,
                Name = p.Name,
                Age = p.Age,
                Active = p.Active,
                CreatedAt = p.CreatedAt,
                UpdatedAt = p.UpdatedAt
            }).ToList();
        }
    }
}
