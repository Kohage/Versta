

using Versta.Data.Models;

namespace Versta.Data.Interfaces
{
    public interface IOrderService
    {
        Task<Order> SaveOrderAsync(Order order);
        IEnumerable<Order> GetAllOrder();
        Order GetOrder(int id);
    }
}
