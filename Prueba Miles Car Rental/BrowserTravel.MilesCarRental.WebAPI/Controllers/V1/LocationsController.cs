﻿using BrowserTravel.MilesCarRental.Core.Entities;
using BrowserTravel.MilesCarRental.WebAPI.Mappers;
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

        [HttpGet]
        public async Task<ActionResult<ICollection<LocalityDto>>> Get()
        {
            var obj = await _localityRepository.GetAllAsync();
            return Ok(obj.Maps());
        }
    }
}
