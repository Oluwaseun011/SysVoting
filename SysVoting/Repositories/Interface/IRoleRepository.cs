using SysVoting.Models.Entities;
using System.Linq.Expressions;

namespace SysVoting.Repositories.Interface
{
    public interface IRoleRepository : IBaseRepository<Role>
    {
        Task<Role> Get(int id);
        Task<Role> Get(Expression<Func<Role, bool>> expression);
        Task<ICollection<Role>> GetAll();
    }
}
