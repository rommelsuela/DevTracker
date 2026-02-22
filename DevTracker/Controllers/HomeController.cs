using Microsoft.AspNetCore.Mvc;

namespace DevTracker.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
