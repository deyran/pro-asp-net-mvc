using System;
using System.Collections.Generic;
using System.Web.Mvc;
using LanguageFeature.Models;

namespace LanguageFeature.Controllers
{
    /*
    >> USING OBJECT AND COLLECTION INITIALIZES
    >>>> Listing 4-10. Initializing collections and arrays in the HomeController.cs file
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


    }
}