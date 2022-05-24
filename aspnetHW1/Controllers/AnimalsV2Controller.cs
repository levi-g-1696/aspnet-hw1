using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetHW1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsV2Controller : ControllerBase
    {
        public IActionResult Get()
        {


            return Ok("OK345");
        }
    }
}
