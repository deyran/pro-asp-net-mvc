using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using LanguageFeature.Models;

namespace LanguageFeature.Controllers
{
    /*
    >> PERFORMING LANGUAGE INTEGRATED QUERIES -> 86-91
    >>>> UNDERSTANDING DEFERRED LINQ QUERIES -> 90
    >>>>>>>> Listing 4-31. An immediately executed LINQ query in the in the HomeController.cs file -> 91
     */

    public class HomeController : Controller
    {
        public string Index()
        {
            return "Navigate to a URL to show an example";
        }

        /*  public ViewResult AutoProperty()
          {
              // ... statements omitted for brevity ...
          }*/

        public ViewResult CreateProduct()
        {
            // create and populate a new Product object
            Product myProduct = new Product
            {
                ProductID = 100,
                Name = "Kayak",
                Description = "A boat for one person",
                Price = 275M,
                Category = "Watersports"
            };

            return View(
                "Result",
                (object)String.Format("Category: {0}", myProduct.Category)
            );
        }

        public ViewResult CreateCollection()
        {
            string[] stringArray = { "apple", "orange", "plum" };

            List<int> intList = new List<int> { 10, 20, 30, 40 };

            Dictionary<string, int> myDict = new Dictionary<string, int>
            {
                {"apple", 10}, {"orange", 20}, {"plum", 30}
            };

            return View("Result", (object)stringArray[1]);
        }

        public ViewResult UseExtension()
        {
            ShoppingCart cart = new ShoppingCart
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

            decimal total = 0;

            foreach (Product prod in products.Filter(prod => prod.Category == "Soccer" || prod.Price > 20))
            {
                total += prod.Price;
            }

            return View
            (
                "Result",
                (object)String.Format("Total: {0}", total)
            );

        }

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
            foreach (Product prod in products.FilterByCategory("Soccer"))
            {
                total += prod.Price;
            }

            return View
            (
                "Result",
                (object)String.Format("Total: {0}", total)
            );
        }

        public ViewResult CreateAnonArray()
        {
            var oddsAndEnds = new[]
            {
                new { Name = "MVC", Category = "Pattern" },
                new { Name = "Hat", Category = "Clothing" },
                new { Name = "Apple", Category = "Fruit" }
            };

            StringBuilder result = new StringBuilder();
            foreach (var item in oddsAndEnds)
            {
                result.Append(item.Name).Append("");
            }

            return View
            (
                "Result",
                (object)result.ToString()
            );
        }

        public ViewResult FindProducts()
        {
            Product[] products =
            {
                new Product { Name = "Kayak", Category = "Watersports", Price = 275M},
                new Product { Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
                new Product { Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
                new Product { Name = "Corner flag", Category = "Soccer", Price = 34.95M}
            };

            var foundProducts = products.OrderByDescending(e => e.Price)
                                .Take(3)
                                .Select(e => new { e.Name, e.Price });

            var results = products.Sum(e => e.Price);

            products[2] = new Product { Name = "Stadium", Price = 79500M };

            return View
            (
                "Result",
                (object)result.ToString()
            );
        }

    }
}