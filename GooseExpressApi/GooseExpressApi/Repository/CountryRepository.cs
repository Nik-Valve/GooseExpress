using GooseExpressApi.Data;
using GooseExpressApi.Interfaces;
using GooseExpressApi.Models;

namespace GooseExpressApi.Repository
{
    public class CountryRepository : ICountry
    {
        private readonly DataContext _dataContext;
        public CountryRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public ICollection<Country> GetCountries()
        {
            return _dataContext.Countries.OrderBy(i => i.Id).ToList();
        }
    }
}
