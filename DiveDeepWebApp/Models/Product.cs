namespace DiveDeepWebApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public List<string> Sizes { get; set; }
        public decimal PricePerDay { get; set; }

        public int CategoryId { get; set; }

        public string Type { get; set; }

        public string Gender { get; set; }

        public decimal? Thickness { get; set; }

        public int Volume { get; set; }

        public string Step1 { get; set; }

        public string Step2 { get; set; }

        public string Octopus { get; set; }

    }




}
