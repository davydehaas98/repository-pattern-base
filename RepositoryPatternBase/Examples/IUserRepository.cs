using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternBase.Examples
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        Task<IEnumerable<User>> ReadByNameAsync(string name);
    }
}
