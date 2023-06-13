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
    public class CountryController : Controller
    {
        private readonly DataContext _dataContext;
        private readonly ICountryRepositories _countryRepositories;
        public CountryController(DataContext context,
            ICountryRepositories countryRepositories)
        {
            _countryRepositories = countryRepositories;
            this._dataContext = context;
        }
        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateCategory([FromBody] Country countryCreate)
        {
            if (countryCreate == null)
                return BadRequest(ModelState);
            var country = _countryRepositories.GetAll().Where(c => c.NameofCountry.Trim().ToUpper() == countryCreate.NameofCountry.TrimEnd().ToUpper()).FirstOrDefault();
            if (country != null)
            {
                ModelState.AddModelError("", "Country already exists");
                return StatusCode(422, ModelState);
            }
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _countryRepositories.CreateCountry(countryCreate);
            return Ok("Successfully created");
        }
    }
}
