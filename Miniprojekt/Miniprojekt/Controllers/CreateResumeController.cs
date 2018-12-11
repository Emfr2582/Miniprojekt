using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            var viewModel = new CreateResumeVM
            {
                EducationItems = _resumeService.EducationInfo()
            };

            return View(viewModel);
        }

        [Route("input/Createresume")]
        [HttpPost]
        public IActionResult CreateResume(CreateResumeVM model)
        {
            if (!ModelState.IsValid)
            {
                model.EducationItems = _resumeService.EducationInfo();
                return View("CreateResume", model);
            }
            else
                _resumeService.AddInfo(model);

            return RedirectToAction(nameof(Details));
        }

        public IActionResult Details()
        {
            var viewModel = _resumeService.GetInfo().Last();
            viewModel.EducationItems = _resumeService.EducationInfo();
            return View(viewModel);
        }
    }
}