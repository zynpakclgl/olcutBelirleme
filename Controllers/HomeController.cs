using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using olcutBelirleme.Models;
using System;
using System.Diagnostics;
//using System.Web.Mvc;

namespace olcutBelirleme.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        private static void RastgeleSayi()
        {
            Random r = new Random();
            int sayi = r.Next(100);
            //Console.WriteLine(sayi);
        }

        [HttpPost]      
        public ActionResult Index(string sayi)
        {
            RastgeleSayi();
            
            return Content("Ortalama Puanınız  %85 !!");
        }
       

        /*
        public IActionResult Index()
        {
          
           
            return View();
        }
       */

        public IActionResult Privacy()
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
