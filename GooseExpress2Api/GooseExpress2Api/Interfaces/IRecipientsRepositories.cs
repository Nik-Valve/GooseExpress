using GooseExpress2Api.Models;

namespace GooseExpress2Api.Interfaces
{
    public interface IRecipientsRepositories
    {
        ICollection<Recipient> GetRecipients();
    }
}
