using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternBase.Examples
{
    public class UserService : ServiceBase<User>, IUserService
    {
        private new readonly IUserRepository _repository;

        public UserService(IUserRepository repository) : base(repository)
        {
        }

        public async Task<IEnumerable<User>> GetUsersByName(string name)
        {
            return await _repository.ReadByNameAsync(name);
        }
    }
}
