using GooseExpress2Api.Data;
using GooseExpress2Api.Interfaces;
using GooseExpress2Api.Models;
using GooseExpress2Api.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GooseExpress2Api.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepositories _customerRepositories;
        private readonly DataContext _dataContext;

        public CustomerController(ICustomerRepositories customerRepositories,
                    DataContext dataContext)
        {
            _customerRepositories = customerRepositories;
            _dataContext = dataContext;
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateCategory([FromBody] Customer customer)
        {
            if (customer == null)
                return BadRequest(ModelState);
            var country = _customerRepositories.GetAll().Where(c => c.Phone.Trim().ToUpper() == customer.Phone.TrimEnd().ToUpper())
            .FirstOrDefault();
            if (country != null)
            {
                ModelState.AddModelError("", "Customer already exists");
                return StatusCode(422, ModelState);
            }
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _customerRepositories.CreatyCustomer(customer);
            return Ok("Successfully created");
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Customer>))]
        public IActionResult GetLoginPassword(string username, string password)
        {
            var customers = _customerRepositories.GetLoginAndPassword(username, password);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(customers);
        }
        [HttpGet("{UserId}")]
        [ProducesResponseType(200, Type =typeof(Customer))]
        [ProducesResponseType(400)]
        public IActionResult GetCustomer(int UserId)
        {
            var customers = (from cu in _dataContext.Customer
                             join ci in _dataContext.City on cu.IdCity equals ci.ID
                             where cu.Id == UserId
                             select new { 
                                 cu.Id,
                                 ci.NameOfCity,
                                 cu.Seria,
                                 cu.Number,
                                 cu.LastName,
                                 cu.FirstName,
                                 cu.Patronymic,
                                 cu.LegalAddres,
                                 cu.Phone,
                                 cu.NameOfCustomer,
                                 cu.Image,
                                 cu.Email,
                                 cu.Password}).ToList();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(customers);
        }
        [HttpPut("UpdateUser")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(200)]
        public IActionResult UpdateUSer(int id, [FromBody] Customer updateUser)
        {
            var entity = _dataContext.Customer.FirstOrDefault(i => i.Id == id);
            entity.IdCity = updateUser.IdCity;
            entity.NameOfCustomer = updateUser.NameOfCustomer;
            entity.LegalAddres = updateUser.LegalAddres;
            entity.Phone = updateUser.Phone;
            entity.LastName = updateUser.LastName;
            entity.FirstName = updateUser.FirstName;
            entity.Patronymic = updateUser.Patronymic;
            entity.Email = updateUser.Email;
            entity.Seria = updateUser.Seria;
            entity.Number = updateUser.Number;
            entity.Login = updateUser.Login;
            entity.Password = updateUser.Password;
            entity.Image = updateUser.Image;
            _dataContext.SaveChanges();
            return NoContent();
            //if (updateUser == null)
            //    return BadRequest(ModelState);
            //var user = _customerRepositories.GetAll().Where(u => u.Id == updateUser.Id).FirstOrDefault();
            //if (!ModelState.IsValid)
            //    return BadRequest(ModelState);
            //if (!_customerRepositories.UpdateUser(updateUser))
            //{
            //    ModelState.AddModelError("", "Something went wrong while saving");
            //    return StatusCode(500, ModelState);
            //}
        }
    }
    }
