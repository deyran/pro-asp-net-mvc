using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    /*
    >> PERFORMING LANGUAGE INTEGRATED QUERIES -> 86-91
    >>>> Listing 4-27. Querying without LINQ in the HomeController.cs file -> 86    
    */
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Navigate to a URL to show an example";
        }

        // ...other action methods omitted for brevity ...

        public ViewResult FindProducts()
        {
            Product[] products =
            {
                new Product { Name = "Kayak", Category = "Watersport", Predicate = 275M },
                new Product { Name = "Lifejacket", Category = "Watersport", Predicate = 48.95M },
                new Product { Name = "Soccer ball", Category = "Soccer", Predicate = 19.50M },
                new Product { Name = "Corner flag", Category = "Soccer", Predicate = 34.95M }
            };

            // define the array to hold the results
            Product[] foundProducts = new Product[3];
            // sort the contents of the array
            Array.Sort
            (
                products, (item1, item2) =>
                {
                    return Comparer<decimal>.Default.Compare(item1.Price, item2.Price);
                }
            );
            // get the first three items in the array as the results
            Array.Copy(products, foundProducts, 3);

            // create the result
            StringBuilder result = new StringBuilder();
            foreach(Product p in foundProducts)
            {
                result.AppendFormat("Price: {0}", p.Price);
            }

            return View
            (
                "Result",
                (object)result.ToString()
            );
        }
    }
}