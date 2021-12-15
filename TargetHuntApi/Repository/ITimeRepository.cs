using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TargetHuntApi.Repository
{
    public interface ITimeRepository
    {
        List<string> GetTimes(DateTime date);
    }
}
