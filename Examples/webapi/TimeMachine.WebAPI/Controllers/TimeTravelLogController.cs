using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TimeMachine.WebAPI;

namespace TimeMachine.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class TimeTravelLogController : Controller
    {
        TimeTravelLogRepository timeTravelLogRepository;

        public TimeTravelLogController()
        {
            timeTravelLogRepository = new TimeTravelLogRepository();
        }

        // GET api/TimeTravelLogs
        [HttpGet]
        public IEnumerable<TimeTravelLog> Get()
        {
            return timeTravelLogRepository.GetAll();
        }

        // GET api/TimeTravelLogs/5
        [HttpGet("{id}")]
        public TimeTravelLog Get(int id)
        {
            return timeTravelLogRepository.Get(id);
        }

        // POST api/TimeTravelLogs
        [HttpPost]
        public void Post([FromBody]TimeTravelLog timeTravelLog)
        {
            timeTravelLogRepository.Insert(timeTravelLog);
        }

        // PUT api/TimeTravelLogs/5
        [HttpPut]
        public void Put([FromBody]TimeTravelLog timeTravelLog)
        {
            timeTravelLogRepository.Update(timeTravelLog);
        }

        // DELETE api/TimeTravelLogs/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            timeTravelLogRepository.Delete(id);
        }
    }
}
