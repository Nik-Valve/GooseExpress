using GooseExpress2Api.Data;
using GooseExpress2Api.Interfaces;
using GooseExpress2Api.Models;

namespace GooseExpress2Api.Repositories
{
    public class CityRepositories : ICityRepositories
    {
        private readonly DataContext _dataContext;
        public CityRepositories(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public bool CreateCity(City city)
        {
            _dataContext.Add(city);
            return Save();
        }

        public ICollection<City> GetAll()
        {
            return _dataContext.City.OrderBy(i => i.ID).ToList();
        }

        public City GetCity(string city)
        {
            return _dataContext.City.Where(i => i.NameOfCity == city).FirstOrDefault();
        }

        public bool Save()
        {
            var saved = _dataContext.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UpdateCity(City city)
        {
            _dataContext.Update(city);
            return Save();
        }
    }
}
