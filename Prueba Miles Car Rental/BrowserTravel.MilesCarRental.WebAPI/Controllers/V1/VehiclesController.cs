using BrowserTravel.MilesCarRental.Core.Entities;
using BrowserTravel.MilesCarRental.WebAPI.Mappers;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BrowserTravel.MilesCarRental.WebAPI.Controllers.V1
{
    [Route("api/V1/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IGenericRepository<Vehicle> _vehicleRepository;

        public VehiclesController(IGenericRepository<Vehicle> vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<VehicleDto>>> Get()
        {
            var obj = await _vehicleRepository.GetAllAsync();
            return Ok(obj.Maps());
        }
    }
}
