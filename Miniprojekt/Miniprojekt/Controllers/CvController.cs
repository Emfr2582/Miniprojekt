﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Miniprojekt.Controllers
{
    public class CvController
    {

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

    }
}