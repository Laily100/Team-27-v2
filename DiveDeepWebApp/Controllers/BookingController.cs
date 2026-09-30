using Microsoft.AspNetCore.Mvc;
using DiveDeepWebApp.Persistence;
using DiveDeepWebApp.Models;

namespace DiveDeepWebApp.Controllers
{
    public class BookingController : Controller
    {
        //Controlleren kan nu snakke med databasen med dette
        private readonly BookingDbContext _context;

        public BookingController(BookingDbContext context)
        {
            _context = context;
        }

        public IActionResult CreateBooking(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == id);

            if (product == null)
                return NotFound();

            var booking = new Booking
            {
                ProductId = id,
                Product = product
            };

            return View(booking);
        }

        [HttpPost]
        public IActionResult CreateBooking(Booking Booking)
        {

            var product = _context.Products.FirstOrDefault(p => p.ProductId == Booking.ProductId);
            Booking.Product = product;

            if (Booking.Product == null)
            {
                ModelState.AddModelError("", "Produktet blev ikke fundet.");
                return View(Booking);
            }

            if (Booking.StartDate >= Booking.EndDate)
            {
                ModelState.AddModelError("EndDate", "End date must be after start date.");

            }

            if (Booking.StartDate < DateTime.Now)
            {
                ModelState.AddModelError("StartDate", "Start date cannot be in the past.");

            }

            if (string.IsNullOrWhiteSpace(Booking.CustomerName))
            {
                ModelState.AddModelError("CustomerName", "Udfyld venligst dit navn");
            }

            if (string.IsNullOrWhiteSpace(Booking.PhoneNumber))
            {
                ModelState.AddModelError("PhoneNumber", "Udfyld venligst dit telefonnummer");
            }

            if (string.IsNullOrWhiteSpace(Booking.SelectedSize))
            {
                ModelState.AddModelError("SelectedSize", "Vælg venligst en ønsket størrelse");
            }

            if (Booking.StartDate == default)
            {
                ModelState.AddModelError("StartDate", "Vælg venligst en startdato");
            }

            if (Booking.EndDate == default)
            {
                ModelState.AddModelError("EndDate", "Vælg venligst en slutdato");
            }

            if (!ModelState.IsValid)
            {
                return View(Booking);
            }
            
            var days = (Booking.EndDate - Booking.StartDate).Days;
            Booking.TotalPrice = days * product.PricePerDay;

            //gemmer i databasen
            _context.Bookings.Add(Booking);
            _context.SaveChanges();

            //viser bekræftelsen
            return View("BookingConfirmation", Booking);
        }

        public IActionResult BookingConfirmation(Booking booking)
        {
            return View(booking);
        }
    }
}
