using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;
using WebApplication3.Interfaces;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class FeedBackController : Controller
    {
        private readonly IFeedbakcs feed;
        private readonly ICountry _country;
        private readonly DataContext _context;
        //private readonly IFeedbakcs _pokemonRepository;


        public FeedBackController(IFeedbakcs feedbakcs,ICountry country,DataContext context)
        {
            feed = feedbakcs;
            _country = country;
            this._context = context;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<FeedBack>))]
        public IActionResult GetFeedBacks()
        {
            var pokemons = feed.GetFeedBacks();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(pokemons);
        }
        [HttpGet("Countries")]
        [ProducesResponseType(200, Type = typeof(Country))]
        public IActionResult GetCountryes(int pokeId)
        {
                var pokemons = _country.GetCountries();

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                return Ok(pokemons);
            //if (!feed.GetFeedBackExists(pokeId))
            //    return NotFound();

            ////var pokemon = _mapper.Map<PokemonDto>(_pokemonRepository.GetPokemon(pokeId));
            //var pokemon = feed.GetFeedBack(pokeId);

            //if (!ModelState.IsValid)
            //    return BadRequest(ModelState);

            //return Ok(pokemon);
        }
    }
}
