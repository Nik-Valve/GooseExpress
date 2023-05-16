using WebApplication3.Models;

namespace WebApplication3.Interfaces
{
    public interface IFeedbakcs
    {
        ICollection<FeedBack> GetFeedBacks();
        FeedBack GetFeedBack(int Id);
        FeedBack GetFeedBack(string FirstName);
        decimal GetFeedBackRating(int pokeId);
        bool GetFeedBackExists(int pokeId);
    }
}
