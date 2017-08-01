using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ArduinoAspCore.Model;

namespace ArduinoAspCore.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        DataContext db;
        public ValuesController(DataContext context)
        {
            db = context;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        [HttpPost]
        public IActionResult Post([FromBody]Data data)
        {
            if (data == null)
            {
                return BadRequest();
            }
            db.Datas.Add(data);
            db.SaveChanges();
            return Ok(data);

        }
    }
}
