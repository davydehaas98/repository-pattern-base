using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternBase.Examples
{
    public interface IUserService : IServiceBase<User>
    {
        Task<IEnumerable<User>> GetUsersByName(string name);
    }
}
