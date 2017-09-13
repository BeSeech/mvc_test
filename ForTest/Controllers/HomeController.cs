using Microsoft.AspNetCore.Mvc;
using System.Linq;
using mvc_test.Models;

namespace mvc_test.Controllers
{
    public class HomeController : Controller
    {
        public IRepository Repository = SimpleRepository.SharedRepository;

        // GET
        public IActionResult Index()
        {
            return View(Repository.Products.Where( p => p?.Price < 50));
        }

        [HttpGet]
        public IActionResult AddProduct() => View(new Product());

        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            Repository.AddProduct(p);
            return RedirectToAction("Index");
        }
    }
}