using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    /*
    >> USING ANONUMOUS TYPE -> 84
    >>>> Listing 4-26. Creating an array of anonymously typed object in the HomeController.cs file -> 85    
    */
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Navigate to a URL to show an example";
        }

        // ...other action methods omitted for brevity ...

        public ViewResult CreateAnonArray()
        {
            var oddsAndEnds = new[]
            {
                new { Name = "MVC", Category = "Pattern" },
                new { Name = "Hat", Category = "Clothing" },
                new { Name = "Apple", Category = "Fruit" }
            };

            StringBuilder result = new StringBuilder();
            foreach(var item in oddsAndEnds)
            {
                result.Append(item.Name).Append("");
            }

            return View
            (
                "Result",
                (object)result.ToString()
            );
        }
    }
}