using aspnetHW1.ModelBinders;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetHW1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class CandyController : ControllerBase
    {
        [HttpGet("Search")]
        public IActionResult SearchCandies(
                        [ModelBinder(typeof(CustomBinder))] string[] countries)
        // www.mySite.com/api/search?countries=Canada|India|Israel
        {
            return Ok($"countries : {countries[0]} {countries[1]}");
            //return Ok();
        }
    }
}
