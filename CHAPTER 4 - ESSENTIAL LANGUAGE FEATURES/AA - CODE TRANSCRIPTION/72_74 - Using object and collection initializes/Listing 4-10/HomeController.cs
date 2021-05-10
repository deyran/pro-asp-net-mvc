using System;
using System.Web.Mvc;
using LanguageFeature.Models;
using System.Collections.Generic;

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
        public ViewResult AutoProperty()
        {
            // ... statements omitted for brevity ...
        }
        
        // .. other action methods omitted for brevity ...
        public ViewResult CreateCollection()
        {
            string[] stringArray = {"apple", "orange", "plum" };

            List<int> intList = new List<int> {10, 20, 30, 40 };

            Dictionary<string, int> myDict = new Dictionary<string, int> 
            {
                {"apple", 10}, {"orange", 20}, {"plum", 30}
            };

            return View("Result", (object)stringArray[1]);            
        }        
    }    
}