using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace APIMiniChallenge2.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class MiniChallenge2Controller : ControllerBase
    {
        
        [HttpGet]
        [Route("minichallenge2/{num1}/{num2}")]
        public int minichallenge2(int num1, int num2)
        {
            return num1 + num2;
        }
    }
