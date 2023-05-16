using GooseExpress2Api.Models;

namespace GooseExpress2Api.Interfaces
{
    public interface IOrderRepositories
    {
        ICollection<Order> GetOrders();
    }
}
