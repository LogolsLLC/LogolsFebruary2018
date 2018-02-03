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
    public class StudentController : Controller
    {
        StudentService _service;

        public StudentController()
        {
            _service = new StudentService(new StudentRepository());
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _service.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return _service.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Student student)
        {
            _service.Insert(student);
        }

        // PUT api/values/5
        [HttpPut]
        public void Put([FromBody]Student student)
        {
            _service.Update(student);
        }

        // DELETE api/values/5
        [HttpDelete]
        public void Delete([FromBody]Student student)
        {
            _service.Delete(student);
        }
    }
}
