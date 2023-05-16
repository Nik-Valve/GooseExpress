using GooseExpress2Api.Data;
using GooseExpress2Api.Interfaces;
using GooseExpress2Api.Models;

namespace GooseExpress2Api.Repositories
{
    public class CargoRepositories : ICargoRepositories
    {
        private readonly DataContext _context;
        public CargoRepositories(DataContext context)
        {
            _context = context;
        }
        public ICollection<Cargo> GetAll()
        {
            return _context.Cargo.OrderBy(c => c.Id).ToList();
        }
    }
}
