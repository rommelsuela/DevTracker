using Microsoft.AspNetCore.Mvc;

namespace DevTracker.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
