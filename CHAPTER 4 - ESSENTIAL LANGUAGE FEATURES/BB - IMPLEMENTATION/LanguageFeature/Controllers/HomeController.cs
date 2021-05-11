using System;
using System.Web.Mvc;
using LanguageFeature.Models;

namespace LanguageFeature.Controllers
{
    /*
    >> USING OBJECT AND COLLECTION INITIALIZES
    >>>> Listing 4-9. Using the object Initializer feature in the HomeController.cs file
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

    }
}