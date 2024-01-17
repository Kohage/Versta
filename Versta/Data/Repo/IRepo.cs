namespace Versta.Data.Repo
{
    public interface IRepo<T> where T : class
    {
        Task<T> SaveAsync(T entity);
        Task<List<T>> GetAsync();
    }
}
