using Razor.Models;
using System.Web.Mvc;

namespace Razor.Controllers
{
    /*
    >> PREPARING THE EXAMPLE PROJECT -> 95

    >>>> DEFINING THE MODEL -> 95
    >>>>>>>> Listing 5-2. The content of the HomeController file -> 96     
    ---------------------------------------------------------------------------------------------------------

    >> WORKING WITH LAYOUTS -> 99
    >>>> DEMONSTRATING SHARED LAYOUTS -> 103
    >>>>>>>> Listing 5-10. Adding a new action method to the HomeController.cs file -> 103
    ---------------------------------------------------------------------------------------------------------

    >> USING RAZOR EXPRESSIONS -> 107
    >>>> INSERTING DATA VALUES -> 107
    >>>>>>>> Listing 5-13. The DemoExpression action method in the HomeController.cs file -> 107

    >>>> ENUMERATING ARRAYS AND COLLECTIONS -> 115
    >>>>>>>> Listing 5-18. The DemoArray action method in the HomeController file -> 115
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
        
        public ActionResult DemoExpression()
        {
            ViewBag.ProductCount = 1;
            ViewBag.ExpressShip = true;
            ViewBag.ApplyDicount = false;
            ViewBag.Supplier = null;

            return View(myProduct);
        }

        public ActionResult DemoArray()
        {
            Product[] array =
            {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Coner flag", Price = 34.95M}
            };

            return View(array);
        }
    }
}