using Versta.Data.Interfaces;
using Versta.Data.Models;
using Versta.Data.Repo;


namespace Versta.Data.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepo<OrderViewModel> _OrderRepo = null!;
        public OrderService(IRepo<OrderViewModel> repo)
        {
            _OrderRepo = repo;
        }
        public async Task<OrderViewModel> SaveOrderAsync(OrderViewModel orderModel)
        {
            return await _OrderRepo.SaveAsync(orderModel);
        }
        public IEnumerable<OrderViewModel> GetAllOrder()
        {
            return _OrderRepo.GetAll();
        }
        public OrderViewModel GetOrder(int id)
        {
            return _OrderRepo.GetById(id);
        }
    }
}
