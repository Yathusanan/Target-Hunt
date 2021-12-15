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
    public class InterviewsController : ControllerBase
    {
        private readonly IInterviewRepository _repo;

        public InterviewsController(IInterviewRepository repository)
        {
            _repo = repository;
        }

        [HttpGet]
        public IActionResult InterviewList()
        {
            var interviews = _repo.GetInterviewsDetail();

            var interViewDto = new List<InterviewDto>();

            foreach (var i in interviews)
                interViewDto.Add(new InterviewDto { 
                   Id = i.Id,
                   Time = i.Time,
                   Date = i.Date,
                   CandidateId = i.CandidateId,
                  Candidate = i.Candidate
                });

            return Ok(interViewDto);
        }


        [HttpGet("{id:int}")]
        public IActionResult GetInterview(int id)
        {
            var interview = _repo.GetInterview(id);

            var interviewDto = new InterviewDto
            {
                Id = interview.Id,
                Time = interview.Time,
                Date = interview.Date,
                CandidateId = interview.CandidateId
            };

            return Ok(interviewDto);
        }

        [HttpPatch("{id:int}")]
        public IActionResult UpdateInterview([FromBody] InterviewDto interviewDto)
        {
            if (interviewDto == null)
                return BadRequest(ModelState);

            var interview = new Interview
            {
                Id = interviewDto.Id,
                Date = interviewDto.Date,
                Time = interviewDto.Time,
                CandidateId = interviewDto.CandidateId
            };

           _repo.UpdateInterview(interview);

            return Ok();
        }
    }
}
