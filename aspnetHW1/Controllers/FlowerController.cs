using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetHW1.Controllers
{
    [Route("api/[action]")]
    [ApiController]
    public class FlowerController : ControllerBase
    {
        public string Rose()
        {
            return "ROSE";
        }
        public string Sunflower()
        {
            return "sunflower";
        }
        public string Tulip()
        {
            return "tulip";
        }
        public string Jasmine()
        {
            return "jasmine";
        }

    }
}
