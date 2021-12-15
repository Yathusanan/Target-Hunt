using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TargetHuntApi.Models;

namespace TargetHuntApi.Dto
{
    public class InterviewDto
    {
        public int Id { get; set; }
        public string Time { get; set; }
        public DateTime Date { get; set; }
        public int CandidateId { get; set; }

        public Candidate Candidate { get; set; }
    }
}
