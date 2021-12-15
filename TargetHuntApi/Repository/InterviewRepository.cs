using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TargetHuntApi.Data;
using TargetHuntApi.Models;

namespace TargetHuntApi.Repository
{
    public class InterviewRepository : IInterviewRepository
    {
        private readonly ApplicationDbContext _context;

        public InterviewRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddNewInterview(Interview interview)
        {
            _context.Interviews.Add(interview);
            _context.SaveChanges();
        }

        public Interview GetInterview(int id)
        {
            return _context.Interviews.SingleOrDefault(a => a.Id == id);
        }

        public List<Interview> GetInterviewsDetail()
        {
            return _context.Interviews.Include(c => c.Candidate).ToList();
        }

        public void UpdateInterview(Interview interview)
        {
            _context.Update(interview);
            _context.SaveChanges();
        }
    }
}
