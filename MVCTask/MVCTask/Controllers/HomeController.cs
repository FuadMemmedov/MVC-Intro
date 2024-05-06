using Microsoft.AspNetCore.Mvc;

namespace MVCTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
