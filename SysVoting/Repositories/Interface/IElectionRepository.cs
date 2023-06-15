using SysVoting.Models.Entities;
using System.Linq.Expressions;

namespace SysVoting.Repositories.Interface
{
    public interface IElectionRepository : IBaseRepository<Election>
    {
        Task<Electionr> Get(int id);
        Task<Election> Get(Expression<Func<Election, bool>> expression);
        Task<ICollection<Election>> GetAll();
    }
}
