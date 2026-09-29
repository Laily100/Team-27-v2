namespace DiveDeepWebApp.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalPrice { get; set; }

        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }

        public string SelectedSize { get; set; }

    }
}
