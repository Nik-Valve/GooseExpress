using GooseExpress2Api.Models;

namespace GooseExpress2Api.Interfaces
{
    public interface ICountryRepositories
    {
        ICollection<Country> GetAll();
        bool CreateCountry(Country country);
        bool Save();
    }
}
