using GooseExpress2Api.Models;

namespace GooseExpress2Api.Interfaces
{
    public interface ICityRepositories
    {
        ICollection<City> GetAll();

        City GetCity(string NameCity);
        bool CreateCity(City city);
        bool UpdateCity(City city);
        bool Save();
    }
}
