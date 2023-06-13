using GooseExpress2Api.Data;
using GooseExpress2Api.Interfaces;
using GooseExpress2Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace GooseExpress2Api.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class FeedBackController : Controller
    {
        private readonly IFeedbackRepositories _feedbackRepositories;
        private readonly DataContext _dataContext;

        public FeedBackController(IFeedbackRepositories feedbackRepositories,
                    DataContext dataContext)
        {
            _feedbackRepositories = feedbackRepositories;
            _dataContext = dataContext;
        }
        [HttpGet("FeedBack/All")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<FeedBacks>))]
        public IActionResult GetFeedbacks()
        {
            var feedbacks = _feedbackRepositories.GetAll();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(feedbacks);
        }

    }
}
