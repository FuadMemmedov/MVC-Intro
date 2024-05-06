using Microsoft.AspNetCore.Mvc;

namespace MVCTask.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
