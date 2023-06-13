using GooseExpress2Api.Data;
using GooseExpress2Api.Interfaces;
using GooseExpress2Api.Models;

namespace GooseExpress2Api.Repositories
{
    public class FeedBackRepositories : IFeedbackRepositories
    {
        private readonly DataContext _dataContext;
        public FeedBackRepositories(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public ICollection<FeedBacks> GetAll()
        {
            return _dataContext.FeedBack.OrderBy(i => i.Id).ToList();
        }
    }
}
