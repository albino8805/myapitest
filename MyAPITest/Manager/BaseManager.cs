using MyAPITest.Manager.Interface;
using MyAPITest.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPITest.Manager
{
    /// <summary>
    /// BaseManager
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    /// <typeparam name="UViewModel">The type of the view model.</typeparam>
    public class BaseManager<TEntity, UViewModel> : IBaseManager<TEntity, UViewModel> where TEntity : class where UViewModel : class
    {
        private readonly IBaseRepository<TEntity> _repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRepository{TEntity}" /> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public BaseManager(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        public List<UViewModel> Get()
        {
            var entities = _repository.Get();

            return PrepareMultipleReturn(entities);
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public UViewModel GetById(int id)
        {
            var entity = _repository.GetById(id);

            return PrepareSingleReturn(entity);
        }

        /// <summary>
        /// Patches the specified entity.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model">The entity.</param>
        public void Patch(int id, UViewModel model)
        {
            var entity = _repository.GetById(id);

            var updatedEntity = PrepareUpdateData(entity, model);

            _repository.Patch(updatedEntity);
        }

        /// <summary>
        /// Posts the specified entity.
        /// </summary>
        /// <param name="model">The entity.</param>
        /// <returns></returns>
        public int Post(UViewModel model)
        {
            var entity = PrepareAddData(model);

            return _repository.Post(entity);
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        /// <summary>
        /// Prepares the add data.
        /// </summary>
        /// <param name="viewModel">The view model.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public virtual TEntity PrepareAddData(UViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prepares the update data.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="viewModel">The view model.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public virtual TEntity PrepareUpdateData(TEntity entity, UViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prepares the single return.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public virtual UViewModel PrepareSingleReturn(TEntity entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prepares the multiple return.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public virtual List<UViewModel> PrepareMultipleReturn(List<TEntity> entities)
        {
            throw new NotImplementedException();
        }
    }
}
