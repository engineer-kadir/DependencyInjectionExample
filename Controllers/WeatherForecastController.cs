using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DependencyInjection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly INumGenerator2 numGenerator2;
        private readonly INumGenerator numGenerator;

        public WeatherForecastController(INumGenerator2 NumGenerator2,INumGenerator NumGenerator)
        {
            numGenerator2 = NumGenerator2;
            numGenerator = NumGenerator;
        }
       [HttpGet]
       public String Get()
        {
            //int random1 = numGenerator2.RandomValue;
            int random1 = numGenerator.RandomValue;

            int random2 = numGenerator2.GetNumGeneratorRandomNumber();
            //NumGenerator n = new NumGenerator();
            //int number = n.GetRandomnumber();
            //int number= numGenerator.RandomValue;
            return $"NumGenerator.RandomValue: { random1}, NumGenerator.NumGenerator.RandomValue :  { random2}";
        }
    }
}
