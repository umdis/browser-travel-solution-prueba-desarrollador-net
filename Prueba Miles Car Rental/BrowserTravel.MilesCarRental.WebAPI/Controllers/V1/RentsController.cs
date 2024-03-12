using BrowserTravel.MilesCarRental.WebAPI.Mappers;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BrowserTravel.MilesCarRental.WebAPI.Controllers.V1
{
    [Route("api/V1/[controller]")]
    [ApiController]
    public class RentsController : ControllerBase
    {
        private readonly IRentService _rentService;
        private readonly IRentRepository _rentRepository;

        public RentsController(IRentService rentService, IRentRepository rentRepository)
        {
            _rentService = rentService;
            _rentRepository = rentRepository;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<RentDto>>> Get()
        {
            var obj = await _rentRepository.GetAll();
            return Ok(obj.Map());
        }

        [HttpPost(nameof(GetVehiclesFreeRent))]
        public async Task<ICollection<VehicleRentDto>> GetVehiclesFreeRent(QueryRentDto rentDto)
        {
            var result = await _rentService.GetVehiclesForRentAsync(rentDto.IdPickupLocatity, rentDto.IdReturnLocatity);
            return result.Map();
        }

        [HttpPost(nameof(CreateSeedRent))]
        public async Task<ActionResult> CreateSeedRent()
        {
            await _rentService.CreateSeedRent();
            return Ok("Data de prueba generada");
        }

    }
}
