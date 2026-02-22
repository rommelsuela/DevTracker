using Microsoft.AspNetCore.Mvc;

namespace DevTracker.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
