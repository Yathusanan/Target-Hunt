using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TargetHuntApi.Data;

namespace TargetHuntApi.Repository
{
    public class TimeRepository : ITimeRepository
    {
        private readonly ApplicationDbContext _context;

        public TimeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<string> GetTimes(DateTime date)
        {
            var times = _context.Interviews.Where(d => d.Date == date).Select(c => c.Time).ToList();

            return times;
        }
    }
}
