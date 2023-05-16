using GooseExpressApi.Models;

namespace GooseExpressApi.Interfaces
{
    public interface ICountry
    {
        ICollection<Country> GetCountries();
    }
}
