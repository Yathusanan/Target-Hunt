using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TargetHuntApi.Models;

namespace TargetHuntApi.Repository
{
    public interface ICandidateRepository
    {
        void Addcandidate(Candidate candidate);
    }
}
