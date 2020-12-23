using MongoDB.Driver;
using RepositoryPatternBase.MongoDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternBase.MongoDB
{
    public abstract class MongoDBRepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : EntityBase
    {
        protected readonly IMongoCollection<TEntity> _collection;

        protected MongoDBRepositoryBase(IMongoDBSettings mongoDBSettings)
        {
            var client = new MongoClient(mongoDBSettings.ConnectionString);
            var database = client.GetDatabase(mongoDBSettings.DatabaseName);
            _collection = database.GetCollection<TEntity>(mongoDBSettings.CollectionName);
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            await _collection.InsertOneAsync(entity);

            return entity;
        }

        public async Task<IEnumerable<TEntity>> ReadAsync()
        {
            return await _collection.Find(entity => true).ToListAsync();
        }

        public async Task<TEntity> ReadByIdAsync(Guid id)
        {
            return await _collection.Find(entity => entity.Id == id).FirstOrDefaultAsync();
        }

        public async Task<TEntity> UpdateAsync(Guid id, TEntity entityIn)
        {
            await _collection.ReplaceOneAsync(entity => entity.Id == id, entityIn);

            return await _collection.Find(entity => entity.Id == id).FirstOrDefaultAsync();
        }

        public async Task DeleteByIdAsync(Guid id)
        {
            await _collection.DeleteOneAsync(entity => entity.Id == id);
        }

        public async Task DeleteByEntityAsync(TEntity entityIn)
        {
            await _collection.DeleteOneAsync(entity => entity.Id == entityIn.Id);
        }
    }
}
