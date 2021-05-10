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
        >>>> UNDERSTANDING DEFERRED LINQ QUERIES -> 90
        >>>>>>>> Listing 4-31. An immediately executed LINQ query in the in the HomeController.cs file -> 91
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

                var result = products.Sum(e => e.Price);
                
                products[2] = new Product { Name = "Stadium", Price = 795005M };
    
                retun View
                (
                    "Result",
                    (object)result.ToString()
                );
            }
        }
    }