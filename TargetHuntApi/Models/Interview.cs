using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TargetHuntApi.Models
{
    public class Interview
    {
        public int Id { get; set; }
        public string Time { get; set; }
        public DateTime Date { get; set; }
        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }
    }
}
