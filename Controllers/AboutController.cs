﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using olcutBelirleme.Models;
using System.Diagnostics;

namespace olcutBelirleme.Controllers
{
    public class AboutController : Controller
    {


        private readonly ILogger<HomeController> _logger;

        public AboutController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {


            return View();
        }

        public IActionResult About()
        {

            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}