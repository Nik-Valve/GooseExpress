using GooseExpress2Api.Data;
using GooseExpress2Api.Interfaces;
using GooseExpress2Api.Models;
using Microsoft.EntityFrameworkCore;

namespace GooseExpress2Api.Repositories
{
    public class CustomerRepositories : ICustomerRepositories
    {
        private readonly DataContext _dataContext;
        public CustomerRepositories(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public bool CreatyCustomer(Customer customer)
        {
            _dataContext.Add(customer);
            return Save();
        }

        public ICollection<Customer> GetAll()
        {
            return _dataContext.Customer.OrderBy(i => i.Id).ToList();
        }

        public Customer GetLoginAndPassword(string username, string password)
        {
            return _dataContext.Customer.Where(i => i.Login == username && i.Password == password).FirstOrDefault();
        }

        public bool Save()
        {
            var saved = _dataContext.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UpdateUser(Customer customer)
        {
            _dataContext.Update(customer);
            return Save();
        }
    }
}
