using SysVoting.Models.Entities
using System.Linq.Expressions;
namespace SysVoting.Repositories.Interface
{
    public interface IVotingRepository : IBaseRepository<Voting>
    {
          Task<Voting> Get(int id);
            Task<Voting> Get(Expression<Func<Voting, bool>> expression);
            Task<ICollection<Voting>> GetAll();
        
    }
}