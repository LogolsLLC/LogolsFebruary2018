using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZombieReport.WebAPI;

namespace ZombieReport.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class PersonStatusController : Controller
    {
        PersonStatusRepository repository;

        public PersonStatusController()
        {
            repository = new PersonStatusRepository();
        }

        // GET api/PersonStatus
        [HttpGet]
        public IEnumerable<PersonStatus> Get()
        {
            return repository.GetAll();
        }

        // GET api/PersonStatus/5
        [HttpGet("{id}")]
        public PersonStatus Get(int id)
        {
            return repository.Get(id);
        }

        // POST api/PersonStatus
        [HttpPost]
        public void Post([FromBody]PersonStatus personStatus)
        {
            repository.Insert(personStatus);
        }

        // PUT api/PersonStatus/5
        [HttpPut]
        public void Put([FromBody]PersonStatus personStatus)
        {
            repository.Update(personStatus);
        }

        // DELETE api/PersonStatus/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
