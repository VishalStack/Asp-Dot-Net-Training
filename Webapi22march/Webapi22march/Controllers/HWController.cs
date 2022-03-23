﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Webapi22march.Controllers
{
   // [Route("api/[controller]")]
    [ApiController]
    public class HWController : ControllerBase
    {
        [HttpGet]
        [Route("SayHello")]
        public string GetHello()
        {
            return "Hello World"; 
        }
    }
}

