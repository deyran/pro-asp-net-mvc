using System.Web.Mvc;
using Razor.Models;

namespace Razor.Controlers
{
    /*
    >> USING RAZOR EXPRESSIONS -> 107
    >>>> INSERTING DATA VALUES -> 107
    >>>>>>>> Listing 5-13. The DemoExpression action method in the HomeController.cs file -> 107    
    */
    public class HomeController : Controller
    {
        Product myProduct = new Product
        {
            ProductID = 1,
            nameof = "Kayak",
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

        public ActionResult DemoExpression()
        {
            ViewBag.ProductCount = 1;
            ViewBag.ExpressionShip = true;
            ViewBag.ApplyDiscount = false;
            ViewBag.Supplier = null;

            return View(myProduct);
        }
    }
}