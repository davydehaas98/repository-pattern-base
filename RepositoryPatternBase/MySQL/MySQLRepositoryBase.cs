using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternBase.MySQL
{
    public abstract class MySQLRepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : EntityBase
    {
        protected readonly MySqlConnection _connection;

        protected MySQLRepositoryBase(IMySQLSettings mySQLSettings)
        {
            _connection = new MySqlConnection(mySQLSettings.ConnectionString);
        }

        public Task<TEntity> CreateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByEntityAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TEntity>> ReadAsync()
        {
            await _connection.OpenAsync();

            string query = "SELECT * FROM *";

            var command = new MySqlCommand(query, _connection);

            MySqlDataReader dataReader = (MySqlDataReader)await command.ExecuteReaderAsync();

            while(await dataReader.ReadAsync())
            {

            }

            await _connection.CloseAsync();
        }

        public Task<TEntity> ReadByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(Guid id, TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
