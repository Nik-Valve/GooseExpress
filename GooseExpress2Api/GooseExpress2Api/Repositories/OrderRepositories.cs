using GooseExpress2Api.Data;
using GooseExpress2Api.Interfaces;
using GooseExpress2Api.Models;

namespace GooseExpress2Api.Repositories
{
    public class OrderRepositories : IOrderRepositories
    {
        private readonly DataContext _dataContext;
        public OrderRepositories(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public ICollection<Order> GetOrders()
        {
           return _dataContext.Order.OrderBy(i => i.Id).ToList();
        }
    }
}
