using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreCodeCamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCamps()
        {
            return Ok(new { Moniker = "Namur2020", Name = "Namur Code Camp 2020" });
        }

        [HttpGet("{id}")]
        public object GetObject()
        {
            return Ok(new { ObjectId = 1, Moniker = "Namur 2020", Name = "Namur Code Camp" });
        }
    }
}
