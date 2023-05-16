using GooseExpress2Api.Models;

namespace GooseExpress2Api.Interfaces
{
    public interface IFeedbackRepositories
    {
        ICollection<FeedBacks> GetAll();
    }
}
