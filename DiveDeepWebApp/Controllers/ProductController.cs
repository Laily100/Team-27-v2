using DiveDeepWebApp.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace DiveDeepWebApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BCD()
        {
            var products = ProductRepository.products
                .Where(p => p.CategoryId == 1)
                .ToList();

            return View();
        }

        public IActionResult Wetsuits()
        {
            var products = ProductRepository.products
                .Where(p => p.CategoryId == 2)
                .ToList();
            return View();
        }

        public IActionResult Regulators()
        {
            var products = ProductRepository.products
                .Where(p => p.CategoryId == 4)
                .ToList();
            return View();
        }

        public IActionResult Masks()
        {
            var products = ProductRepository.products
                .Where(p => p.CategoryId == 5)
                .ToList();
            return View();
        }

        public IActionResult Fins()
        {
            var products = ProductRepository.products
                .Where(p => p.CategoryId == 6)
                .ToList();
            return View();
        }




    }
}
