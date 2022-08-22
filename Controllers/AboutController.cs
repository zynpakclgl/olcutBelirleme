using Microsoft.AspNetCore.Mvc;

namespace olcutBelirleme.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
