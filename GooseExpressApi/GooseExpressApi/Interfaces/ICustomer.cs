using GooseExpressApi.Models;

namespace GooseExpressApi.Interfaces
{
    public interface ICustomer
    {
        ICollection<Customer> GetCustomer();

        Customer GetLoginPassword(string login, string password);
    }
}
