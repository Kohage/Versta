using Core.Models;
using Versta.Data.Models;

namespace Versta.Data.Repo
{
    public interface IRepo<T> where T : BaseEntity
    {
        Task<T> SaveAsync(T entity);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
