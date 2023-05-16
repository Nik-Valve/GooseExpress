using GooseExpress2Api.Data;
using GooseExpress2Api.Interfaces;
using GooseExpress2Api.Models;

namespace GooseExpress2Api.Repositories
{
    public class CountryRepositories :ICountryRepositories
    {
        private readonly DataContext _context;
        public CountryRepositories(DataContext context)
        {
            _context = context;
        }
        public ICollection<Country> GetAll()
        {
            return _context.Country.OrderBy(c => c.Id).ToList();
        }
    }
}
