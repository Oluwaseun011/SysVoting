using SysVoting.Models.Entities;
using System.Linq.Expressions;

namespace SysVoting.Repositories.Interface
{
    public interface IResultRepository :IBaseRepository<Result>
    {
        Task<Result> Get(int id);
        Task<Result> Get(Expression<Func<Result, bool>> expression);
        Task<ICollection<Result>> GetAll();
    }
}
