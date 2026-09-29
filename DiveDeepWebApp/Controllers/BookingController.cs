using Microsoft.AspNetCore.Mvc;
using DiveDeepWebApp.Persistence;
using DiveDeepWebApp.Models;

namespace DiveDeepWebApp.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult CreateBooking(int id)
        {
            var product = ProductRepository.products.FirstOrDefault(p => p.ProductId == id);

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

            if (Booking.StartDate >= Booking.EndDate)
            {
                ModelState.AddModelError("EndDate", "End date must be after start date.");
                return View(Booking);
            }

            if (Booking.StartDate < DateTime.Now)
            {
                ModelState.AddModelError("StartDate", "Start date cannot be in the past.");
                return View(Booking);
            }

            var product = ProductRepository.products.FirstOrDefault(p => p.ProductId == Booking.ProductId);
            Booking.Product = product;

            var days = (Booking.EndDate - Booking.StartDate).Days;
            Booking.TotalPrice = days * product.PricePerDay;

            if (ModelState.IsValid)
            {
                // Here you would typically save the booking to a database
                // For this example, we'll just redirect to a confirmation page
                return RedirectToAction("BookingConfirmation", new { id = Booking.BookingId });
            }
            // If the model state is not valid, return the view with the current booking data
            return View(Booking);
        }

        public IActionResult BookingConfirmation(int id)
        {
            // Here you would typically retrieve the booking from a database using the id
            // For this example, we'll just create a dummy booking for demonstration purposes
            var booking = new Booking
            {
                BookingId = id,
                ProductId = 1, // Example product ID
                Product = ProductRepository.products.FirstOrDefault(p => p.ProductId == 1),
                StartDate = DateTime.Now.AddDays(1),
                EndDate = DateTime.Now.AddDays(3),
                TotalPrice = 200, // Example total price
                CustomerName = "John Doe",
                PhoneNumber = "1234567890",
                SelectedSize = "M"
            };
            return View(booking);
        }
    }
}
