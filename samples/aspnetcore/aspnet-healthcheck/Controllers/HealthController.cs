using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_healthcheck.Controllers
{
    [Route("api/Health")]
    public class HealthController : Controller
    {
        [HttpGet]
        public IActionResult Get() => Ok("ok");
    }
}
