using Razor.Models;
using System.Web.Mvc;

namespace Razor.Controllers
{
    /*
    >> PREPARING THE EXAMPLE PROJECT -> 95
    >>>> DEFINING THE MODEL -> 95
    >>>>>>>> Listing 5-2. The content of the HomeController file -> 96     

    >> WORKINK WITH LAYOUTS -> 99
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

        // GET: Home
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