using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ForTest.Models;

namespace ForTest.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View(SimpleRepository.SharedRepository.Products);
        }
    }
}