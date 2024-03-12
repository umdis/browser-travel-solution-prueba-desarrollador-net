using BrowserTravel.MilesCarRental.Core.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BrowserTravel.MilesCarRental.WebAPI.Controllers.V1
{
    [Route("api/V1/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly IGenericRepository<Locality> _localityRepository;

        public LocationsController(IGenericRepository<Locality> localityRepository)
        {
            _localityRepository = localityRepository;
        }

        // GET: api/<LocationsController>
        [HttpGet]
        public async Task<ActionResult<List<Locality>>> Get()
        {
            var obj = await _localityRepository.GetAllAsync();
            return Ok(obj);
        }

        // GET api/<LocationsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LocationsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LocationsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LocationsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
