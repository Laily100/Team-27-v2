using DiveDeepWebApp.Models;

namespace DiveDeepWebApp.Persistence
{
    public class CategoryRepository
    {
        public List<Category> categories = new List<Category>()
        {
            new Category
            {
                CategoryId = 1,
                CategoryName = "BDC"
            },

            new Category
            {
                CategoryId = 2,
                CategoryName = "Dykkerdragter"
            },

            new Category
            {
                CategoryId = 3,
                CategoryName = "Tanke"
            },

            new Category
            {
                CategoryId = 4,
                CategoryName = "Regulatorsæt"
            },

            new Category
            {
                CategoryId = 5,
                CategoryName = "Maske/Snorkel"
            },

            new Category
            {
                CategoryId = 6,
                CategoryName = "Finner"
            }

        };

        

    }
}
