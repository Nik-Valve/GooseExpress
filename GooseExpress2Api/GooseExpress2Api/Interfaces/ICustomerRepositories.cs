using GooseExpress2Api.Models;

namespace GooseExpress2Api.Interfaces
{
    public interface ICustomerRepositories
    {
        ICollection<Customer> GetAll();
        Customer GetLoginAndPassword(string username, string password);

    }
}
