using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TargetHuntApi.Models;

namespace TargetHuntApi.Repository
{
    public interface IInterviewRepository
    {
        void AddNewInterview(Interview interview);

        List<Interview> GetInterviewsDetail();

        Interview GetInterview(int id);

        void UpdateInterview(Interview interview);
    }
}
