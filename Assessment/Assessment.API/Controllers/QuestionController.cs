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
    public class QuestionController : Controller
    {
        QuestionService _service;

        public QuestionController()
        {
            _service = new QuestionService(new QuestionRepository());
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Question> Get()
        {
            return _service.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Question Get(int id)
        {
            return _service.Get(id);
        }

        // GET api/values
        [HttpGet("Answers/{id}")]
        public IEnumerable<Answer> Answers(int id)
        {
            return _service.GetAnswers(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Question question)
        {
            _service.Insert(question);
        }

        // PUT api/values/5
        [HttpPut]
        public void Put([FromBody]Question question)
        {
            _service.Update(question);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
