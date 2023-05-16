using GooseExpress2Api.Data;
using GooseExpress2Api.Interfaces;
using GooseExpress2Api.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc;
using GooseExpress2Api.Repositories;

namespace GooseExpress2Api.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class CargoController : Controller
    {
        private readonly ICargoRepositories _cargoRepositories;
        private readonly ICountryRepositories _countryRepositories;
        private readonly ICustomerRepositories _customerRepositories;
        private readonly IFeedbackRepositories _feedbackRepositories;
        private readonly IOrderRepositories _orderRepositories;
        private readonly IRecipientsRepositories _recipientsRepositories;
        private readonly DataContext _dataContext;

        public CargoController(ICargoRepositories cargoRepositories,
            DataContext context, 
            ICountryRepositories countryRepositories,
            ICustomerRepositories customerRepositories,
            IFeedbackRepositories feedbackRepositories,
            IRecipientsRepositories recipientsRepositories,
            IOrderRepositories orderRepositories)
        {
            _cargoRepositories = cargoRepositories;
            _countryRepositories = countryRepositories;
            _customerRepositories = customerRepositories;
            _feedbackRepositories = feedbackRepositories;
            this._dataContext = context;
            _recipientsRepositories = recipientsRepositories;
            _orderRepositories = orderRepositories;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Cargo>))]
        public IActionResult GetAll()
        {
            var cargoes = _cargoRepositories.GetAll();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(cargoes);
        }
        [HttpGet("Countries")]
        [ProducesResponseType(200, Type = typeof(Country))]
        public IActionResult GetCountryes(int pokeId)
        {
            var pokemons = _countryRepositories.GetAll();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(pokemons);
        }
        [HttpGet ("Customer")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Customer>))]
        public IActionResult GetCustomer()
        {
            var customers = _customerRepositories.GetAll();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(customers);
        }
        private class LoginAndPassword
        {
            string _login;
            string _password;
        }
        [HttpGet("Customer/LoginPassword")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Customer>))]
        public IActionResult GetLoginPassword(string username,string password)
        {
            var customers = _customerRepositories.GetLoginAndPassword(username,password);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(customers);
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
        [HttpGet("Order/All")]
        [ProducesResponseType(200, Type = typeof (IEnumerable<Order>))]
        public IActionResult GetOrders()
        {
            var orders = _orderRepositories.GetOrders();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(orders);
        }
        [HttpGet("Recipients/All")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Recipient>))]
        public IActionResult GetRecipients()
        {
            var recipients = _recipientsRepositories.GetRecipients();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(recipients);
        }
        //[HttpGet("HistoryOrder/All")]
        //[ProducesResponseType(200, Type = typeof(IEnumerable<Order>))]
        //public IActionResult GetHistory()
        //{
        //    var history = _historyOrderRepositories.historyOrders();
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);

        //    return Ok(history);
        //}
    }
}
