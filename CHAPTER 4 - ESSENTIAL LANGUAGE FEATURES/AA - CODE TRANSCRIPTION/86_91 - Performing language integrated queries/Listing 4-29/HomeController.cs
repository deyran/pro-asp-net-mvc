    using System;
    using System.Collectios.Generic;
    using System.Linq;
    using System.Text;
    using System.Web.Mvc;
    using LanguageFeatures.Models;

    namespace LanguageFeature.Controllers
    {
        /*
        >> PERFORMING LANGUAGE INTEGRATED QUERIES -> 86-91
        >>>> Listing 4-29. Using LINQ dot notation in the HomeController.cs file -> 88
        */
        public class HomeController : Controller
        {
            public string Index()
            {
                return "Navigate to a URL to show an example";
            }

            // ...other action methods omitted for brevity...

            public ViewResult FindProducts()
            {
                Product[] =
                {
                    new Product { Name = "Kayak", Category = "Watersport", Price = 275M },
                    new Product { Name = "Lifejacket", Category = "Watersport", Price = 48.95M },
                    new Product { Name = "Soccer ball", Category = "Soccer", Price = 19.50M },
                    new Product { Name = "Coner flag", Category = "Soccer", Price = 34.95M }
                };

                var foundProducts = products.OrderByDescending(e => e.Price)
                                    .Take(3)
                                    .Select(e => new{ e.Name, e.Price });

                StringBuilder result = new StringBuilder();
                foreach(var p in foundProducts)
                {
                    result.AppendFormat("Price: {0} ", p.Price);
                }

                retun View
                (
                    "Result",
                    (object)result.ToString()
                );
            }
        }
    }