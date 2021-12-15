using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TargetHuntApi.Helpers
{
    public static class TimeSlots
    {
        public static List<string> Times()
        {
            var times = new List<string>()
            {
                "08.00 am",
                "08.30 am",
                "09.00 am",
                "09.30 am",
                "10.00 am",
                "10.30 am",
                "11.00 am",
                "11.30 am",
                "12.00 pm",
                "12.30 pm",
                "01.00 pm",
                "01.30 pm",
                "02.00 pm",
                "02.30 pm",
                "03.00 pm",
                "03.30 pm",
                "04.00 pm",
                "04.30 pm"
            };

            return times;
        }
    }
}
