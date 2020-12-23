using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternBase
{
    public abstract class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : EntityBase
    {
        protected IRepositoryBase<TEntity> _repository;
        
        protected ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            return await _repository.CreateAsync(entity);
        }

        public async Task DeleteByIdAsync(Guid id)
        {
            await _repository.DeleteByIdAsync(id);
        }

        public async Task DeleteByEntityAsync(TEntity entity)
        {
            await _repository.DeleteByEntityAsync(entity);
        }

        public async Task<IEnumerable<TEntity>> ReadAsync()
        {
            return await _repository.ReadAsync();
        }

        public async Task<TEntity> ReadByIdAsync(Guid id)
        {
            return await _repository.ReadByIdAsync(id);
        }

        public async Task<TEntity> UpdateAsync(Guid id, TEntity entity)
        {
            return await _repository.UpdateAsync(id, entity);
        }
    }
}
