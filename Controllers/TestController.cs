using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly INumGenerator numGenerator;

        public TestController(INumGenerator NumGenerator)
        {
            numGenerator = NumGenerator;
        }
        [HttpGet]
        public string Get()
        {
            //NumGenerator n = new NumGenerator();
            int number = numGenerator.RandomValue;
            return number.ToString();
        }
    }
}
