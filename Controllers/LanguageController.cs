using Microsoft.AspNetCore.Mvc;

namespace olcutBelirleme.Controllers
{
    public class LanguageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
