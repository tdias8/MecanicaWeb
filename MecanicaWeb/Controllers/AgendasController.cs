﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MecanicaWeb.Controllers
{
    public class AgendasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}