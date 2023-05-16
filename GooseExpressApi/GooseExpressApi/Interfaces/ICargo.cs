using GooseExpressApi.Models;

namespace GooseExpressApi.Interfaces
{
    public interface ICargo
    {
        ICollection<Cargo> GetCargo();
        bool GetFeedBackExists(int pokeId);
        Cargo GetFeedBack(int Id);
    }
}
