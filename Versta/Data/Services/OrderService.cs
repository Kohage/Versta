using Versta.Data.Interfaces;
using Versta.Data.Models;
using Versta.Data.Repo;

namespace Versta.Data.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepo<Order> _OrderRepo = null!;
        public OrderService(IRepo<Order> repo)
        {
            _OrderRepo = repo;
        }
        public async Task<Order> SaveOrderAsync(Order order)
        {
            return await _OrderRepo.SaveAsync(order);
        }
        public IEnumerable<string> GetPropertyPatientNames()
        {
            var type = typeof(Order).GetProperties();
            return type.Select(prop => prop.Name).ToList();
        }
    }
}
