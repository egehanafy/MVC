using Microsoft.AspNetCore.Mvc;

namespace MVC_Empty_New.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //https://localhost:44368/Product/Index

        public IActionResult Create()
        {
            return View();
        }
        //https://localhost:44368/Product/Create


        public IActionResult Details()
        {
            return View();
        }
        //https://localhost:44368/Product/Details

    }
}
