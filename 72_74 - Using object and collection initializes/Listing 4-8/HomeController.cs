using System;
using System.Web.Mvc;
using LanguageFeature.Models;

namespace LanguageFeature.Controllers
{
    /*
    >> USING OBJECT AND COLLECTION INITIALIZES
    >>>> Listing 4-8. Constructing and initializing an object with properties in the HomeController.cs file
    */
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Navigate to a URL to show an example";
        }
        public ViewResult AutoProperty()
        {
            // ... statements omitted for brevity ...
        }
        public ViewResult CreateProduct()
        {
            // create a new Product object
            Product myProduct = new Product();

            // set the property value
            myProduct.ProductID = 100;
            myProduct.Name = "Kayak";
            myProduct.Description = "A boat for one person";
            myProduct.Price = 275M;
            myProduct.Category = "Watersports";

            return View (
                "Result",
                (object)String.Format("Category: {0}", myProduct.Category)
            );
        }

    }    
}