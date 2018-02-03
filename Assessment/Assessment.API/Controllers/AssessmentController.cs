using Assessment.DAL;
using Assessment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assessment.API.Controllers
{
    [Route("api/[controller]")]
    public class AssessmentController : Controller
    {
        AssessmentService _service;

        public AssessmentController()
        {
            _service = new AssessmentService(new AssessmentRepository());
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Assessment.Entities.Assessment> Get()
        {
            return _service.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Assessment.Entities.Assessment Get(int id)
        {
            return _service.Get(id);
        }

        // GET api/values
        [HttpGet("Questions/{id}")]
        public IEnumerable<Question> Questions(int id)
        {
            return _service.GetQuestions(id);
        }

        // GET api/values
        [HttpGet("Answers/{id}")]
        public IEnumerable<Answer> Answers(int id)
        {
            return _service.GetAnswers(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Assessment.Entities.Assessment assessment)
        {
            _service.Insert(assessment);
        }

        // PUT api/values/5
        [HttpPut]
        public void Put([FromBody]Assessment.Entities.Assessment assessment)
        {
            _service.Update(assessment);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
