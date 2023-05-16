using GooseExpressApi.Data;
using GooseExpressApi.Interfaces;
using GooseExpressApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GooseExpressApi.Repository
{
    public class CargoRepository : ICargo
    {
        private readonly DataContext _dataContext;
        public CargoRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public ICollection<Cargo> GetCargo()
        {
            return _dataContext.Cargos.OrderBy(i => i.Id).ToList();
        }
        public bool GetFeedBackExists(int pokeId)
        {
            return _dataContext.Cargos.Any(i => i.Id == pokeId);
        }
        public Cargo GetFeedBack(int Id)
        {
            return _dataContext.Cargos.Where(i => i.Id == Id).FirstOrDefault();
        }
    }
}
