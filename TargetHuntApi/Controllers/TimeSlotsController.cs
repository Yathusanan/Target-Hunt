using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TargetHuntApi.Helpers;
using TargetHuntApi.Repository;

namespace TargetHuntApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeSlotsController : ControllerBase
    {
        private readonly ITimeRepository _timeRepo;

        public TimeSlotsController(ITimeRepository timeRepository)
        {
            _timeRepo = timeRepository;
        }

        [HttpGet("{date:DateTime?}")]
        public IActionResult AvailableTimeSlots(DateTime? date)
        {
            var today = DateTime.Today;

            if (date != null)
                today = Convert.ToDateTime(date);

            var availableTimes = TimeSlots.Times();

            var reservedTimes = _timeRepo.GetTimes(today);

            if (reservedTimes.Count > 0)
            {
                foreach (var time in reservedTimes)
                {
                    availableTimes.Remove(time);
                }
            } 

            return Ok(availableTimes);
        }
    }
}
