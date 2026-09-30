using DiveDeepWebApp.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace DiveDeepWebApp.Controllers
{
    public class ProductController : Controller
    {

        private readonly BookingDbContext _context;

        public ProductController(BookingDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BCD()
        {
            var products = _context.Products.Where(p => p.CategoryId == 1).ToList();


            return View(products);
        }

        public IActionResult ProductDetails(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        

        public IActionResult Wetsuits()
        {
            var products = _context.Products.Where(p => p.CategoryId == 2).ToList();

            return View(products);
        }

        public IActionResult Tanks()
        {
            var products = _context.Products.Where(p => p.CategoryId == 3).ToList();

            return View(products);
        }

        public IActionResult Regulators()
        {
            var products = _context.Products.Where(p => p.CategoryId == 4).ToList();

            return View(products);
        }

        public IActionResult Masks()
        {
            var products = _context.Products.Where(p => p.CategoryId == 5).ToList();

            return View(products);
        }

        public IActionResult Fins()
        {
            var products = _context.Products.Where(p => p.CategoryId == 6).ToList();

            return View(products);
        }




    }
}
