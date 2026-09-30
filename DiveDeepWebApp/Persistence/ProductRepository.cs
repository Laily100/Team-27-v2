//using DiveDeepWebApp.Models;
//namespace DiveDeepWebApp.Persistence
//{
//    public static class ProductRepository
//    {
//        public static List<Product> products = new List<Product>
//        {
//            new Product
//            {
//                ProductId = 1,
//                Brand = "Scubapro",
//                Model = "Navigator Lite BCD",
//                Sizes = new List<string> { "S", "M", "L" },
//                PricePerDay = 125,
//                CategoryId = 1
//            },

//            new Product
//            {
//                ProductId = 2,
//                Brand = "Scubapro",
//                Model = "BCD Glide",
//                Sizes = new List<string> { "S", "M", "L" },
//                PricePerDay = 140,
//                CategoryId = 1
//            },

//            new Product
//            {
//                ProductId = 3,
//                Brand = "Scubapro",
//                Model = "BCD Hydros Pro",
//                Sizes = new List<string> { "S", "M", "L" },
//                PricePerDay = 200,
//                CategoryId = 1
//            },

//            new Product
//            {
//                ProductId = 4,
//                Brand = "Seac",
//                Model = "BCD Modular",
//                Sizes = new List<string> { "S", "M", "L" },
//                PricePerDay = 145,
//                CategoryId = 1
//            },

//            new Product
//            {
//                ProductId = 5,
//                Brand = "Scubapro",
//                Model = "Definition",
//                Sizes = new List<string> { "XS", "S", "M", "L", "XL" },
//                Type = "Våddragt",
//                Gender = "Herre/Dame",
//                Thickness = 3,
//                PricePerDay = 100,
//                CategoryId = 2
//            },

//            new Product
//            {
//                ProductId = 6,
//                Brand = "Scubapro",
//                Model = "Definition",
//                Sizes = new List<string> { "XS", "S", "M", "L", "XL" },
//                Type = "Våddragt",
//                Gender = "Herre/Dame",
//                Thickness = 5,
//                PricePerDay = 100,
//                CategoryId = 2
//            },

//            new Product
//            {
//                ProductId = 7,
//                Brand = "Scubapro",
//                Model = "Definition",
//                Sizes = new List<string> { "XS", "S", "M", "L", "XL" },
//                Type = "Våddragt",
//                Gender = "Herre/Dame",
//                Thickness = 7,
//                PricePerDay = 100,
//                CategoryId = 2
//            },

//            new Product
//            {
//                ProductId = 8,
//                Brand = "Waterproof",
//                Model = "W5",
//                Sizes = new List<string> { "XS", "S", "M", "L", "XL" },
//                Type = "Våddragt",
//                Gender = "Herre/Dame",
//                Thickness = 3.5m,
//                PricePerDay = 100,
//                CategoryId = 2
//            },

//            new Product
//            {
//                ProductId = 9,
//                Brand = "Fourth Element",
//                Model = "Proteus",
//                Sizes = new List<string> { "XS", "S", "M", "L", "XL" },
//                Type = "Våddragt",
//                Gender = "Herre/Dame",
//                Thickness = 5m,
//                PricePerDay = 120,
//                CategoryId = 2
//            },

//            new Product
//            {
//                ProductId = 10,
//                Brand = "Scubapro",
//                Model = "Exodry 4.0",
//                Sizes = new List<string> { "XS", "S", "M", "L", "XL" },
//                Type = "Tørdragt",
//                Gender = "Herre/Dame",
//                Thickness = null,
//                PricePerDay = 300,
//                CategoryId = 2
//            },

//            new Product
//            {
//                ProductId = 11,
//                Brand = "Waterproof",
//                Model = "D7 Evo",
//                Sizes = new List<string> { "XS", "S", "M", "L", "XL" },
//                Type = "Tørdragt",
//                Gender = "Herre/Dame",
//                Thickness = null,
//                PricePerDay = 320,
//                CategoryId = 2
//            },

//            new Product
//            {
//                ProductId = 12,
//                Brand = "Santi",
//                Model = "E.Lite Plus",
//                Sizes = new List<string> { "XS", "S", "M", "L", "XL" },
//                Type = "Tørdragt",
//                Gender = "Herre/Dame",
//                Thickness = null,
//                PricePerDay = 350,
//                CategoryId = 2
//            },

//            new Product
//            {
//                ProductId = 13,
//                Brand = "Scubapro",
//                Volume = 5,
//                PricePerDay = 150,
//                CategoryId = 3
//            },

//            new Product
//            {
//                ProductId = 14,
//                Brand = "Scubapro",
//                Volume = 10,
//                PricePerDay = 160,
//                CategoryId = 3
//            },

//            new Product
//            {
//                ProductId = 15,
//                Brand = "Scubapro",
//                Volume = 12,
//                PricePerDay = 170,
//                CategoryId = 3
//            },

//            new Product
//            {
//                ProductId = 16,
//                Brand = "Scubapro",
//                Volume = 15,
//                PricePerDay = 180,
//                CategoryId = 3
//            },

//            new Product
//            {
//                ProductId = 17,
//                Brand = "Scubapro",
//                Step1 = "MK25EVO",
//                Step2 = "S600",
//                Octopus = "R105",
//                PricePerDay = 125,
//                CategoryId = 4
//            },

//            new Product
//            {
//                ProductId = 18,
//                Brand = "Scubapro",
//                Step1 = "MK17EVO",
//                Step2 = "C370",
//                Octopus = "R095",
//                PricePerDay = 100,
//                CategoryId = 4
//            },

//            new Product
//            {
//                ProductId = 19,
//                Brand = "Scubapro",
//                Step1 = "MK25EVO BT",
//                Step2 = "A700 Carbon BT",
//                Octopus = "S270",
//                PricePerDay = 150,
//                CategoryId = 4
//            },

//            new Product
//            {
//                ProductId = 20,
//                Brand = "Scubapro",
//                Model = "Ghost",
//                PricePerDay = 50,
//                CategoryId = 5
//            },

//            new Product
//            {
//                ProductId = 21,
//                Brand = "Scubapro",
//                Model = "D-Mask",
//                PricePerDay = 60,
//                CategoryId = 5
//            },

//            new Product
//            {
//                ProductId = 22,
//                Brand = "Scubapro",
//                Model = "Spectra Mini",
//                PricePerDay = 50,
//                CategoryId = 5
//            },

//            new Product
//            {
//                ProductId = 23,
//                Brand = "Scubapro",
//                Model = "Crystal VU",
//                PricePerDay = 75,
//                CategoryId = 5
//            },

//            new Product
//            {
//                ProductId = 24,
//                Brand = "Scubapro",
//                Model = "Crystal VU",
//                PricePerDay = 75,
//                CategoryId = 5
//            },

//            new Product
//            {
//                ProductId = 25,
//                Brand = "Fourth Element",
//                Model = "Scout Kontrast",
//                PricePerDay = 75,
//                CategoryId = 5
//            },

//            new Product
//            {
//                ProductId = 26,
//                Brand = "Fourth Element",
//                Model = "Scout Enhance",
//                PricePerDay = 75,
//                CategoryId = 5
//            },

//            new Product
//            {
//                ProductId = 27,
//                Brand = "Tusa",
//                Model = "Element",
//                PricePerDay = 75,
//                CategoryId = 5
//            },

//              new Product
//            {
//                ProductId = 28,
//                Brand = "Scubapro",
//                Model = "Jet Fin",
//                Sizes = new List<string> { "XS", "S", "M", "L", "XL" },
//                PricePerDay = 50,
//                CategoryId = 6
//            },

//              new Product
//            {
//                ProductId = 29,
//                Brand = "Scubapro",
//                Model = "GO Travel",
//                Sizes = new List<string> { "XS", "S", "M", "L", "XL" },
//                PricePerDay = 50,
//                CategoryId = 6
//            },

//              new Product
//            {
//                ProductId = 30,
//                Brand = "Scubapro",
//                Model = "Seawing Supernova",
//                Sizes = new List<string> { "XS", "S", "M", "L", "XL" },
//                PricePerDay = 60,
//                CategoryId = 6
//            },

//              new Product
//            {
//                ProductId = 31,
//                Brand = "Seac",
//                Model = "Propulsion",
//                Sizes = new List<string> { "XS", "S", "M", "L", "XL" },
//                PricePerDay = 50,
//                CategoryId = 6
//            },

//              new Product
//            {
//                ProductId = 32,
//                Brand = "Seac",
//                Model = "ALA",
//                Sizes = new List<string> { "XS", "S", "M", "L", "XL" },
//                PricePerDay = 50,
//                CategoryId = 6
//            },

//              new Product
//            {
//                ProductId = 33,
//                Brand = "Fourth Element",
//                Model = "Tech",
//                Sizes = new List<string> { "XS", "S", "M", "L", "XL" },
//                PricePerDay = 75,
//                CategoryId = 6
//            },

//              new Product
//            {
//                ProductId = 34,
//                Brand = "Fourth Element",
//                Model = "Rec Fin",
//                Sizes = new List<string> { "XS", "S", "M", "L", "XL" },
//                PricePerDay = 80,
//                CategoryId = 6
//            },


//        };

//    }
//}
