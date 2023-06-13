using GooseExpress2Api.Data;
using GooseExpress2Api.Interfaces;
using GooseExpress2Api.Models;
using GooseExpress2Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GooseExpress2Api.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class CityController : Controller
    {
        private readonly DataContext _dataContext;
        private readonly ICityRepositories _cityRepositories;
        public CityController(DataContext dataContext, ICityRepositories cityRepositories)
        {
            _dataContext = dataContext;
            _cityRepositories = cityRepositories;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<City>))]
        public IActionResult Get(string NameCity) {
        var city = _cityRepositories.GetCity(NameCity);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(city);
        }
        //[HttpPost]
        //[ProducesResponseType(204)]
        //[ProducesResponseType(400)]
        //public IActionResult CreateCity([FromBody] City city)
        //{
        //    if (city == null)
        //        return BadRequest(ModelState);
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);
        //    _cityRepositories.CreateCity(city);
        //    return Ok("Successfully created");
        //}
        [HttpPut("UpdateCity")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(200)]
        public IActionResult UpdateUSer(int id,[FromBody] City updateUser)
        {
            var entity = _dataContext.City.FirstOrDefault(i => i.ID == id);
            entity.NameOfCity = updateUser.NameOfCity;
            entity.IDDistrict = updateUser.IDDistrict;
            entity.CodeCity = updateUser.CodeCity;
            _dataContext.SaveChanges();
            return NoContent();
            //if (updateUser == null)
            //    return BadRequest(ModelState);
            //var user = _cityRepositories.GetAll().Where(u => u.CodeCity == updateUser.CodeCity).FirstOrDefault();
            ////updateUser.ID = user.ID;
            ////if(i != updateUser.ID)
            ////    return BadRequest(ModelState);
            //if (!ModelState.IsValid)
            //    return BadRequest(ModelState);
            //if (!_cityRepositories.UpdateCity(updateUser))
            //{
            //    ModelState.AddModelError("", "Something went wrong while saving");
            //    return StatusCode(500, ModelState);
            //}
            //return NoContent();
        }

    }
}
