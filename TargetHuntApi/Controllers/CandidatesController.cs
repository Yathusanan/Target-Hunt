using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TargetHuntApi.Dto;
using TargetHuntApi.Models;
using TargetHuntApi.Repository;

namespace TargetHuntApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatesController : ControllerBase
    {
        private readonly ICandidateRepository _repo;

        public CandidatesController(ICandidateRepository repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public IActionResult RegisterCandidate([FromBody]CandidateDto candidateDto)
        {
            if (candidateDto == null)
                return BadRequest(ModelState);

            var candidate = new Candidate
            {
                Firstname = candidateDto.Firstname,
                Lastname = candidateDto.Lastname,
                DateOfBirth = candidateDto.DateOfBirth,
                Phone = candidateDto.Phone,
                Email = candidateDto.Email
            };

            _repo.Addcandidate(candidate);

            return Ok(candidate.Id);
        }

    }
}
