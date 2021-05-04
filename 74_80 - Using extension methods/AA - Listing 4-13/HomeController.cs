using System;
using System.Collections.Generic;
using System.Web.Mvc;
using LanguageFeature.Models;

namespace LanguageFeature.Controllers
{
    /*
    >> USING EXTENSION METHODS - 74-80
    >>>> Listing 4-13 - Applying and extension method in the HomeController.cs file    
    */
    public class HomeController: Controller
    {
        public string Index()
        {
            return "Navigate to a URL to show an example";
        }

        // ... other action methods omitted for brevity...

        public ViewResult UseExtension()
        {
            // create and populate ShoppingCard
            ShoppingCart car = new ShoppingCart
            {
                Products = new List<Product>
                {
                    new Product { Name = "Kayak", Price = 275M },
                    new Product { Name = "Lifejacket", Price = 48.95M },
                    new Product { Name = "Soccer ball", Price = 19.50M },
                    new Product { Name = "Corner flag", Price = 34.95M }
                }
            };

            // get the total value of the products in the cart
            decimal cartTotal = cart.TotalPrices();

            return View
            (
                "Result", 
                (object)String.Format("Total: {0:c}", cartTotal)
            );
        }
    }
}