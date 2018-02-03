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
    public class SubjectController : Controller
    {
        SubjectService _service;

        public SubjectController()
        {
            _service = new SubjectService(new SubjectRepository());
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Subject> Get()
        {
            return _service.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Subject Get(int id)
        {
            return _service.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Subject subject)
        {
            _service.Insert(subject);
        }

        // PUT api/values/5
        [HttpPut]
        public void Put([FromBody]Subject subject)
        {
            _service.Update(subject);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
