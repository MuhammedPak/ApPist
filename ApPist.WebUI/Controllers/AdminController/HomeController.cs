﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApPist.WebUI.Models;

namespace ApPist.WebUI.Controllers
{
    public class HomeController : AuthBaseController
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
