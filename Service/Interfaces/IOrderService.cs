

using Versta.Data.Models;

namespace Versta.Data.Interfaces
{
    public interface IOrderService
    {
        Task<OrderViewModel> SaveOrderAsync(OrderViewModel orderModel);
        IEnumerable<OrderViewModel> GetAllOrder();
        OrderViewModel GetOrder(int id);
    }
}
