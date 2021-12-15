using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TargetHuntApi.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
