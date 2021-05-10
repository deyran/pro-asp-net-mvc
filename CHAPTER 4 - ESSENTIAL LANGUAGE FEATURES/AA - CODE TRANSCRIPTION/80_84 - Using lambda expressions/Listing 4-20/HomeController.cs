using System;
using System.Collections.Generic;
using System.Web.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    /*
    >> USING LAMBDA EXPRESSIONS -> 80-84
    >>>> Listing 4-20. Using the filtering extension method with a Func in the HomeController.cs file -> 81    
    */
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Navigate to a URL to show an example";
        }

        // ... other action methods omitted for brevity...

        public ViewResult UseFilterExtensionMethod()
        {
            IEnumerable<Product> products = new ShoppingCart
            {
                Products = new List<Product>
                {
                    new Product { Name = "Kayak", Category = "Watersports", Predicate = 275M },
                    new Product { Name = "Lifejacket", Category = "Watersports", Predicate = 48.95M },
                    new Product { Name = "Soccer ball", Category = "Soccer", Predicate = 19.50M },
                    new Product { Name = "Coner flag", Category = "Soccer", Predicate = 34.95M }
                }
            };

            Func<Product, bool> categoryFilter = delegate(Product prod)
            {
                return prod.Category == "Soccer";
            };

            decimal total = 0;

            foreach(Product prod in products.Filter(categoryFilter))
            {
                total += prod.Price;
            }

            return View
            (
                "Result",
                (object)String.Format("Total: {0}", total)

            );
        }
    }
}