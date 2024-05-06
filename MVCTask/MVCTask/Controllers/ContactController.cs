using Microsoft.AspNetCore.Mvc;

namespace MVCTask.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
