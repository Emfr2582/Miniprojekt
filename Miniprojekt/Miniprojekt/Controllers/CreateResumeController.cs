using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Miniprojekt.Controllers
{
    public class CreateResumeController : Controller
    {
       
        [Route("")]
        [Route("Create/Resume")]
        [HttpGet]
        public IActionResult CreateResume()
        {
            return View();
        }
    }
}