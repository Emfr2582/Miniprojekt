using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Miniprojekt.Controllers
{
    public class CreateResumeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        [Route("")]
        [Route("Create/Resume")]
        public IActionResult CreateResume()
        {
            return Content("tja");
        }
    }
}