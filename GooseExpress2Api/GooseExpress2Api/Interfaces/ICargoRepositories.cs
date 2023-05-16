using GooseExpress2Api.Models;

namespace GooseExpress2Api.Interfaces
{
    public interface ICargoRepositories
    {
        ICollection<Cargo> GetAll();
    }
}
