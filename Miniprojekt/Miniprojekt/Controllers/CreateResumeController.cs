using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Miniprojekt.Models.ViewModels;

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

        [Route("input/Createresume")]
        [HttpPost]
        public IActionResult CreateResume(CreateResumeVM model)
        {
            return Content("hej");
        }
    }
}