using Infinite.TaxiBookingSystem.API.Models;
using Infinite.TaxiBookingSystem.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infinite.TaxiBookingSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxiController : ControllerBase
    {
        private readonly IGetRepository<Taxi> _repository;

        public TaxiController(IGetRepository<Taxi> repository)
        {
            _repository = repository;
        }

        [HttpGet("GetAllTaxis")]
        public IEnumerable<Taxi> GetTaxis()
        {
            return _repository.GetAll();
        }
    }
}
