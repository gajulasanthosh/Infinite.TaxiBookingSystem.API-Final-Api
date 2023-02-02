using Infinite.TaxiBookingSystem.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infinite.TaxiBookingSystem.API.Repositories
{
    public class TaxiRepository : IGetRepository<Taxi>
    {
        private readonly ApplicationDbContext _dbContext;

        public TaxiRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Taxi> GetAll()
        {
            return _dbContext.Taxis.ToList();
        }

        public Task<Taxi> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
