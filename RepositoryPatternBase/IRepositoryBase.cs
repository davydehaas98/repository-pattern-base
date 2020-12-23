using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryPatternBase
{
    public interface IRepositoryBase<TEntity> where TEntity : EntityBase
    {
        /// <summary>
        ///     Creates a new entity.
        /// </summary>
        /// <param name="entity">Entity to be saved</param>
        /// <returns>Created entity</returns>
        Task<TEntity> CreateAsync(TEntity entity);

        /// <summary>
        ///     Gets a list of all the entities.
        /// </summary>
        /// <returns>List of all the entities</returns>
        Task<IEnumerable<TEntity>> ReadAsync();

        /// <summary>
        ///     Gets a single entity by GUID.
        /// </summary>
        /// <param name="id">The GUID to search for</param>
        /// <returns>Entity with the corresponding GUID</returns>
        Task<TEntity> ReadByIdAsync(Guid id);

        /// <summary>
        ///     Updates an existing entity.
        /// </summary>
        /// <param name="id">GUID of the user</param>
        /// <param name="entity">Entity with updated fields</param>
        /// <returns>Updated user</returns>
        Task<TEntity> UpdateAsync(Guid id, TEntity entity);

        /// <summary>
        ///     Removes an entity by GUID.
        /// </summary>
        /// <param name="id">GUID of the entity to remove</param>
        /// <returns>Async task to await</returns>
        Task DeleteByIdAsync(Guid id);

        /// <summary>
        ///     Removes an entity.
        /// </summary>
        /// <param name="entity">Entity to remove</param>
        /// <returns>Async task to await</returns>
        Task DeleteByEntityAsync(TEntity entity);
    }
}