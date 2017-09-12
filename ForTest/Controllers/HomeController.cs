using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ForTest.Models;

namespace ForTest.Controllers
{
    public class HomeController : Controller
    {
        SimpleRepository Repository = SimpleRepository.SharedRepository;

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