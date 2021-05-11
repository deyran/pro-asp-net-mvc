using System;
using System.Collections.Generic;
using System.Web.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    /*
    >> USING EXTENSION METHODS -> 74-80
    >>>> Creating filtering extension methods -> 79
    >>>>>>>> Listing 4-18 - Using the filtering extension method in the HomeController.cs file -> 79
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
                    new Product { Name = "Kayak", Category = "Watersports", Price = 275M },
                    new Product { Name = "Lifejacket", Category = "Watersports", Price = 48.95M },
                    new Product { Name = "Soccer ball", Category = "Soccer", Price = 19.50M },
                    new Product { Name = "Coner flag", Category = "Soccer", Price = 34.95M }
                }
            };

            decimal total = 0;
            foreach(Product prod in products.FilterByCategory("Soccer"))
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