using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using olcutBelirleme.Models;


namespace olcutBelirleme.Controllers
{
    public class NotlarController : Controller
    {
        private readonly ConnectionStringClass _cc;

        public NotlarController(ConnectionStringClass cc)
        {
            _cc = cc;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(NotlarClass notobj)
        {
            _cc.Add(notobj);
            _cc.SaveChanges();
            ViewBag.message = "The Selected RadioButton Value " + notobj.Notpuani + "is saved successfully...!!!";
            return View();
        }
    }
}
