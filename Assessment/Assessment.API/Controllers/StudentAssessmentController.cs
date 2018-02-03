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
    public class StudentAssessmentController : Controller
    {
        StudentAssessmentService _service;

        public StudentAssessmentController()
        {
            _service = new StudentAssessmentService(new StudentAssessmentRepository());
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<StudentAssessment> Get()
        {
            return _service.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public StudentAssessment Get(int id)
        {
            return _service.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]StudentAssessment studentAssessment)
        {
            _service.Insert(studentAssessment);
        }

        // PUT api/values/5
        [HttpPut]
        public void Put([FromBody]StudentAssessment studentAssessment)
        {
            _service.Update(studentAssessment);
        }

        // DELETE api/values/5
        [HttpDelete]
        public void Delete([FromBody]StudentAssessment studentAssessment)
        {
            _service.Delete(studentAssessment);
        }
    }
}
