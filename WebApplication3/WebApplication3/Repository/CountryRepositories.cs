using WebApplication3.Data;
using WebApplication3.Interfaces;
using WebApplication3.Models;

namespace WebApplication3.Repository
{
    public class CountryRepositories : ICountry
    {
        private readonly DataContext _context;

        public CountryRepositories(DataContext context)
        {
            _context = context;
        }

        public ICollection<Country> GetCountries()
        {
            return _context.Country.OrderBy(p => p.Id).ToList();
        }


    }
}
