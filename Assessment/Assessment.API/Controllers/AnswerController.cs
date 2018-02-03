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
    public class AnswerController : Controller
    {
        AnswerService _service;

        public AnswerController()
        {
            _service = new AnswerService(new AnswerRepository());
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Answer> Get()
        {
            return _service.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Answer Get(int id)
        {
            return _service.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Answer answer)
        {
            _service.Insert(answer);
        }

        // PUT api/values/5
        [HttpPut]
        public void Put([FromBody]Answer answer)
        {
            _service.Update(answer);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
