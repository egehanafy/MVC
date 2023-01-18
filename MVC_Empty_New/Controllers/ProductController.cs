using Microsoft.AspNetCore.Mvc;
using MVC_Empty_New.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVC_Empty_New.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products = new List<Product>()
            {
                new Product{ID =1,ProductName="Chai",UnitPrice=18},
                new Product{ID =2,ProductName="Chang",UnitPrice=20},
                new Product{ID =3,ProductName="Ikura",UnitPrice=25}
            };

        //Ürün Listesi
        public IActionResult Index()
        {
            
            return View(products);
        }
        //https://localhost:44368/Product/Index

        //Ürün Oluşturma
        public IActionResult Create()
        {
            return View();
        }
        //https://localhost:44368/Product/Create
        
        //Ürün Detay
        public IActionResult Details(int id)//3
        {
            //ID'de yakalanan değere göre products içerisinden ilgili tekil product'ı alarak view'ın modeline gönderin. Gönderdikten sonra detay sayfasında detayını gösterin.

            //return View(products.Where(x=>x.ID == id).ToList());

            Product product = new Product();
            foreach (var item in products)
            {
                if (item.ID == id)
                {
                    product = item;
                }
            }

            //Product product = products.Where(x => x.ID == id).FirstOrDefault();

            //Product product = products.Find(id);

            return View(product);
        }
        //https://localhost:44368/Product/Details

    }
}
