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

        public bool CreateCountry(Country country)
        {
            _context.Add(country);
            return Save();
        }

        //public bool CreateCountry(int Id, string NameOfCountry, int CodeCountry)
        //{
        //    var countryOwnerEntities = _context.Customer.Where(a => a.Id == Id).FirstOrDefault();
        //    var 
        //}

        public ICollection<Country> GetAll()
        {
            return _context.Country.OrderBy(c => c.Id).ToList();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false; 
        }
    }
}
