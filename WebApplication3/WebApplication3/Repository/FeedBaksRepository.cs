using WebApplication3.Data;
using WebApplication3.Interfaces;
using WebApplication3.Models;

namespace WebApplication3.Repository
{
    public class FeedBaksRepository : IFeedbakcs
    {
        private readonly DataContext _context;

        public FeedBaksRepository(DataContext context)
        {
            _context = context;
        }
        public ICollection<FeedBack> GetFeedBacks()
        {
            return _context.FeedBacks.OrderBy(p => p.Id).ToList();
        }

        public FeedBack GetFeedBack(int Id)
        {
            return _context.FeedBacks.Where(i => i.Id == Id).FirstOrDefault();
        }

        public FeedBack GetFeedBack(string FirstName)
        {
            return _context.FeedBacks.Where(i => i.FisrtName == FirstName).FirstOrDefault();
        }

        public bool GetFeedBackExists(int pokeId)
        {
            return _context.FeedBacks.Any(i => i.Id == pokeId);
        }

        public decimal GetFeedBackRating(int pokeId)
        {
            throw new NotImplementedException();
        }

        //public decimal GetFeedBackRating(int pokeId)
        //{
        //    var review = _context.Reviews.Where(p => p.Pokemon.Id == pokeId);

        //    if (review.Count() <= 0)
        //        return 0;

        //    return ((decimal)review.Sum(r => r.Rating) / review.Count());
        //}



    }
}
