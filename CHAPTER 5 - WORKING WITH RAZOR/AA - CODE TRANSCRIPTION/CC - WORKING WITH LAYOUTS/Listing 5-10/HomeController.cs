using System.Web.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    /*
    >> WORKING WITH LAYOUTS -> 99
    >>>> DEMONSTRATING SHARED LAYOUTS -> 103
    >>>>>>>> Listing 5-10. Adding a new action method to the HomeController.cs file -> 103    
    */

    public class HomeController : Controller
    {
        Product myProduct = new Product
        {
            ProductID = 1,
            Name = "Kayak",
            Description = "A boat for one person",
            Category = "Watersports",
            Price = 275M
        };

        public ActionResult Index()
        {
            return View(myProduct);
        }

        public ActionResult NameAndPrice()
        {
            return View(myProduct);
        }
    }
}