using GooseExpress2Api.Data;
using GooseExpress2Api.Interfaces;
using GooseExpress2Api.Models;

namespace GooseExpress2Api.Repositories
{
    public class RecipientRepository : IRecipientsRepositories
    {
        private readonly DataContext _dataContext;
        public RecipientRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public ICollection<Recipient> GetRecipients()
        {
            return _dataContext.Recipient.OrderBy(r => r.Id).ToList();
        }
    }
}
