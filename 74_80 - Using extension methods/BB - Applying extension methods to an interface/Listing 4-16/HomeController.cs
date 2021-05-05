using System;
using System.Collections.Generic;
using System.Web.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    /*
    >> USING EXTENSION METHODS -> 74-80
    >>>> Applying extension methods to an interface -> 76
    >>>>>>>> Listing 4-16 - Extension Methods applies to implementations of an interface in the HomeController.cs file -> 77    
    */
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Navigate to a URL to show an example";
        }

        // ...other action methods omitthed for brevity...

        public ViewResult UseExtensionEnumerable()
        {
            IEnumerable<Product> products = new ShoppingCart
            {
                Products = new List<Product>
                {
                    new Product { Name = "Kayk", Price = 275M },
                    new Product { Name = "Lifejacket", Price = 48.95M },
                    new Product { Name = "Soccer ball", Price = 19.50M },
                    new Product { Name = "Corner flag", Price = 34.95M }
                }
            };

            // create and populate an array of Product objects
            products[] productArray =
            {
                new Product { Name = "Kayk", Price = 275M },
                new Product { Name = "Lifejacket", Price = 48.95M },
                new Product { Name = "Soccer ball", Price = 19.50M },
                new Product { Name = "Corner flag", Price = 34.95M }
            };

            // get the total value of the products in the cart
            decimal cartTotal = products.TotalPrices();
            decimal arrayTotal = products.TotalPrices();

            return View
            (
                "Result",
                (object)String.Format("Cart Total: {0}, Array Total: {1}", cartTotal, arrayTotal)
            );
        }
    }
}