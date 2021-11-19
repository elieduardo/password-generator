using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExemploAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return BadRequest();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Generator generator = new Generator();
            switch (id)
            {
                case 1:
                    return Ok(generator.EasyPassword());
                case 2:
                    return Ok(generator.MidiumPassword());
                case 3:
                    return Ok(generator.HardPassword());
                case 4:
                    return Ok(generator.OnlyNumberPassword());
                default:
                    return NotFound();
            }
        }
    }
}
