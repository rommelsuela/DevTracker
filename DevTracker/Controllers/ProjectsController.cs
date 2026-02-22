using Microsoft.AspNetCore.Mvc;

namespace DevTracker.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
