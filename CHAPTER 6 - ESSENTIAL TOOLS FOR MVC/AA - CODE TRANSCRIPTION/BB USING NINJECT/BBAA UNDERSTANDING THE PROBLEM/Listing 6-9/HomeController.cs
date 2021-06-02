using System.Web.Mvc;
using System.Linq;
using EssentialTools.Models;

namespace EssentialTools.Controllers
{
    /*
    AA PREPEARING THE EXAMPLE PROJECT -> 120
    AABB ADDING THE CONTROLLER -> 121
    >> Listing 6-4. The contents of the HomeController.cs file -> 122   

    BB USING NINJECT -> 123
    BBAA UNDERSTANDING THE PROBLEM -> 123
    >> APPLYING AN INTERFACE -> 123
    >>>> Listing 6-9. Applying the interface to the HomeController.cs -> 124    
    */
    public class HomeController : Controller
    {
        private Product[] products =
        {
            new Product { Name = "Kayak", Category = "Watersports", Price = 275M },
            new Product { Name = "Lifejacket", Category = "Watersports", Price = 48.95M },
            new Product { Name = "Soccer ball", Category = "Soccer", Price = 19.50M },
            new Product { Name = "Corner flag", Category = "Soccer", Price = 34.95M }
        };

        public ActionResult Index()
        {
            IValueCalculator calc = new LinqValueCalculator();
            ShoppingCart cart = new ShoppingCart(calc) { Products = products };
            decimal totalValue = cart.CalculateProductTotal();

            return View(totalValue);
        }
    }
}