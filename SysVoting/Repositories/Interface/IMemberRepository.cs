using SysVoting.Models.Entities;
using System.Linq.Expressions;

namespace SysVoting.Repositories.Interface
{
    public interface IMemberRepository :IBaseRepository<Member>
    {
        Task<Member> Get(int id);
        Task<Member> Get(Expression<Func<Member, bool>> expression);
        Task<ICollection<Member>> GetAll();
    }
}
