namespace OnlineRestaurant.Repositories.Interface
{
    public interface IBaseRepository<T>
    {
        Task<T> Add(T entity);
        Task<T> Update (T entity);
        bool save();
    }
}
