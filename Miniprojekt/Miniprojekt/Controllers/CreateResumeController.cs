using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Miniprojekt.Models.ViewModels;
using Miniprojekt.Services;

namespace Miniprojekt.Controllers
{

    public class CreateResumeController : Controller
    {
        private IResumeService _resumeService;

        public CreateResumeController(IResumeService service)
        {
            _resumeService = service;
        }

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
            if (!ModelState.IsValid)
                return View("CreateResume", model);
            else
                _resumeService.AddInfo(model);
            return View(model);
        }
    }
}