using Microsoft.AspNetCore.Mvc;

namespace MVC_Empty.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    return "Web sayfasına hoşgeldiniz!";
        //}

        //Index
        public IActionResult Index()
        {
            return View();
        }

        //https://localhost:44357/Home/About
        //About
        //Hakkımızda Sayfası

        public IActionResult Action()
        {
            return View();
        }

        //https://localhost:44357/Home/Contact
        //Contact
        //İletişim

        public IActionResult Contact()
        {
            return View();
        }
    }
}
