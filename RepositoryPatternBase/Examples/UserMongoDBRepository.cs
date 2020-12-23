using MongoDB.Driver;
using RepositoryPatternBase.MongoDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternBase.Examples
{
    public class UserMongoDBRepository : MongoDBRepositoryBase<User>, IUserRepository
    {
        public UserMongoDBRepository(IMongoDBSettings mongoDBSettings) : base(mongoDBSettings)
        {

        }

        public async Task<IEnumerable<User>> ReadByNameAsync(string name)
        {
            return await _collection.Find(user => user.Name == name).ToListAsync();
        }
    }
}
