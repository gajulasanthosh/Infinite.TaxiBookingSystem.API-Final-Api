using Infinite.TaxiBookingSystem.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infinite.TaxiBookingSystem.API.Repositories
{
    public class FeedbackRepository :IGetRepository<Feedback>, IRepository<Feedback>
    {
        private readonly ApplicationDbContext _Context;
        public FeedbackRepository(ApplicationDbContext context)
        {
            _Context = context;
        }
        public async Task Create(Feedback obj)
        {
            if (obj != null)
            {
                _Context.Feedbacks.Add(obj);
                await _Context.SaveChangesAsync();
            }
        }
        public Task<Feedback> Delete(int id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Feedback> GetAll()
        {
            return _Context.Feedbacks.ToList();
            //throw new NotImplementedException();
        }
        public async Task<Feedback> GetById(int id)
        {
            var feedback = await _Context.Feedbacks.FindAsync(id);
            if (feedback != null)
            {
                return feedback;
            }
            return null;
        }
        public Task<Feedback> Update(int id, Feedback obj)
        {
            throw new NotImplementedException();
        }
    }
}
