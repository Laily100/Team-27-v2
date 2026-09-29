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

            return View(products);
        }

        public IActionResult ProductDetails(int id)
        {
            var product = ProductRepository.products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        public IActionResult Wetsuits()
        {
            var products = ProductRepository.products
                .Where(p => p.CategoryId == 2)
                .ToList();
            return View(products);
        }

        public IActionResult Tanks()
        {
            var products = ProductRepository.products
                .Where(p => p.CategoryId == 3)
                .ToList();
            return View(products);
        }

        public IActionResult Regulators()
        {
            var products = ProductRepository.products
                .Where(p => p.CategoryId == 4)
                .ToList();
            return View(products);
        }

        public IActionResult Masks()
        {
            var products = ProductRepository.products
                .Where(p => p.CategoryId == 5)
                .ToList();
            return View(products);
        }

        public IActionResult Fins()
        {
            var products = ProductRepository.products
                .Where(p => p.CategoryId == 6)
                .ToList();
            return View(products);
        }




    }
}
