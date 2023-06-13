using GooseExpress2Api.Models;

namespace GooseExpress2Api.Interfaces
{
    public interface ICustomerRepositories
    {
        ICollection<Customer> GetAll();
        Customer GetLoginAndPassword(string username, string password);
        bool CreatyCustomer(Customer customer);
        bool UpdateUser(Customer customer);
        bool Save();
    }
}
