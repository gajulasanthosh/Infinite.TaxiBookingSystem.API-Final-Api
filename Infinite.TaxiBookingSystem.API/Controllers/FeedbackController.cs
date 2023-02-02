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
    public class FeedbackController : ControllerBase
    {
        private readonly IRepository<Feedback> _repository;
        private readonly IGetRepository<Feedback> _getRepository;
        private readonly ApplicationDbContext _dbContext; public FeedbackController(IRepository<Feedback> repository, IGetRepository<Feedback> getRepository, ApplicationDbContext dbContext)
        {
            _repository = repository;
            _getRepository = getRepository;
            _dbContext = dbContext;
        }
        [HttpGet("GetAllFeedBacks")]
        public IEnumerable<Feedback> GetAllFeedBacks()
        {
            return _getRepository.GetAll();
        }
        [HttpGet("GetFeedBackById/{id}", Name = "GetFeedBackById")]
        public async Task<IActionResult> GetFeedBackById(int id)
        {
            var feedback = await _getRepository.GetById(id);
            if (feedback != null)
            {
                return Ok(feedback);
            }
            return NotFound("not found");
        }
        [HttpPost("CreateFeedBack")]
        public async Task<IActionResult> CreateFeedBack([FromBody] Feedback feedback)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _repository.Create(feedback);
            return CreatedAtRoute("GetFeedBackById", new { id = feedback.id }, feedback);
        }
    }
}
