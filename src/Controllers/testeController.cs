using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace tempoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class testeController : ControllerBase
    {
         private readonly ILogger<WeatherForecastController> _logger;

        public testeController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            var rng = new Random();
            return "ok";
        }
    }
}
