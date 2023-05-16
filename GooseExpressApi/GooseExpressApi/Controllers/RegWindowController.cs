using GooseExpressApi.Data;
using GooseExpressApi.Interfaces;
using GooseExpressApi.Models;
using GooseExpressApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace GooseExpressApi.Controllers
{
    [Route ("api/controller")]
    [ApiController]
    public class RegWindowController : Controller
    {
        private readonly DataContext _dataContext;
        //private readonly ICustomer customer;
        private readonly ICargo _cargo;
        private readonly ICountry _country;

        public RegWindowController(DataContext dataContext,ICargo cargo, ICountry country)
        {
            _dataContext = dataContext;
            _cargo = cargo;
            _country = country;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Country>))]
        public IActionResult GetCountries()
        {
            var cargos = _country.GetCountries();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(cargos);
        }
        //[HttpGet]
        //public Customer GetCustomer(string login,string password)
        //{
        //    var authUser = _dataContext.Customers.
        //    Where(i => i.Login == login && i.Password == password).FirstOrDefault();
        //    return authUser;
        //}
        //[HttpGet]
        //[ProducesResponseType(200,Type = typeof(IEnumerable<Cargo>))]
        //public IActionResult GetCargo()
        //{
        //    var cargos = _cargo.GetCargo();
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);

        //    return Ok(cargos);
        //}
        //[HttpGet("{pokeId}")]
        //[ProducesResponseType(200, Type = typeof(Cargo))]
        //[ProducesResponseType(400)]
        //public IActionResult GetPokemon(int pokeId)
        //{
        //    if (!_cargo.GetFeedBackExists(pokeId))
        //        return NotFound();

        //    //var pokemon = _mapper.Map<PokemonDto>(_pokemonRepository.GetPokemon(pokeId));
        //    var pokemon = _cargo.GetFeedBack(pokeId);

        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);

        //    return Ok(pokemon);
        //}
    }
}
