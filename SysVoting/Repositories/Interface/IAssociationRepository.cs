using SysVoting.Models.Entities;
using System.Linq.Expressions;

namespace SysVoting.Repositories.Interface
{
    public interface IAssociationRepository : IBaseRepository<Association>
    {
        Task<Association> Get(int id);
        Task<Association> Get(Expression<Func<Association, bool>> expression);
        Task<ICollection<Association>> GetAll();
    }
}
