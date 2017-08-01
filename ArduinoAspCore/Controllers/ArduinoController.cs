using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ArduinoAspCore.Model;
using Newtonsoft.Json;

namespace ArduinoAspCore.Controllers
{
    //[Produces("application/json")]
    [Route("api/[controller]")]
    public class ArduinoController : Controller
    {
        DataContext db;
        public ArduinoController (DataContext context)
        {
            db = context;
        }

        [HttpPost]      
       public IActionResult Post ([FromBody]Data data)
        {
            if (data == null)
            {
                return BadRequest();
            }
            db.Datas.Add(data);
            db.SaveChanges();
            return Ok(data);

        }
        
        [Route("Testr")]       
        public bool Testr(string jsonOfLog)
        {
            
            try
            {
            var Info = JsonConvert.DeserializeObject<Data>(jsonOfLog);
            db.Datas.Add(Info);
            db.SaveChanges();
            return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }
        [HttpGet]
        [Route("View")]
        public ActionResult View()
        {
            return View("View");
        }

    }

    }
