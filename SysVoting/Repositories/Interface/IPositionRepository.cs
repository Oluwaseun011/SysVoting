using SysVoting.Models.Entities;
using System.Linq.Expressions;

namespace SysVoting.Repositories.Interface
{
    public interface IPositionRepository : IBaseRepository<Position>
    {
        Task<Position> Get(int id);
        Task<Position> Get(Expression<Func<Position, bool>> expression);
        Task<ICollection<Position>> GetAll();
    }
}
