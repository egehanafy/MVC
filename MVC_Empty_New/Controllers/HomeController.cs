using Microsoft.AspNetCore.Mvc;

namespace MVC_Empty_New.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
