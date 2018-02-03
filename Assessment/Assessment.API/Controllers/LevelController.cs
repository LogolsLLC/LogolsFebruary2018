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
    public class LevelController : Controller
    {
        LevelService _service;

        public LevelController()
        {
            _service = new LevelService(new LevelRepository());
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Level> Get()
        {
            return _service.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Level Get(int id)
        {
            return _service.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Level level)
        {
            _service.Insert(level);
        }

        // PUT api/values/5
        [HttpPut]
        public void Put([FromBody]Level level)
        {
            _service.Update(level);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
