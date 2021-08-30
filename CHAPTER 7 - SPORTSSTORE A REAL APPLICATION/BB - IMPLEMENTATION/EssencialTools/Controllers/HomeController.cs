using System.Web.Mvc;
using EssencialTools.Models;
using Ninject;

namespace EssencialTools.Controllers
{
    /*
    AA PREPEARING THE EXAMPLE PROJECT -> 120
        AABB ADDING THE CONTROLLER -> 121
        >> Listing 6-4. The contents of the HomeController.cs file -> 122    

    BB USING NINJECT -> 123
        BBAA UNDERSTANDING THE PROBLEM -> 123
            >> APPLYING AN INTERFACE -> 123
                >>>> Listing 6-9. Applying the interface to the HomeController.cs -> 124    

        BBCC GETTING STARTED WITH NINJECT -> 125
            >> Listing 6-10. Adding the basic Ninject functionality to the index action method in the HomeController.cs file -> 125

        BBDD SETTING UP MVC DEPENDENCY INJECTION -> 127
            >> REFACTORING THE HOME CONTROLLER -> 128
                >>>> Listing 6-13. Refactoring the controller in the HomeController.cs file -> 128

        BBHH SETTING THE OBJECT SCOPE -> 134
            >> Listing 6-24. Using multiple instance of the calculator class in the HomeController.cs -> 135
    */
    public class HomeController : Controller
    {
        private IValueCalculator calc;

        private Product[] products =
        {
            new Product { Name = "Kayak", Category = "Watersports", Price = 275M },
            new Product { Name = "Lifejacket", Category = "Watersports", Price = 48.95M },
            new Product { Name = "Soccer ball", Category = "Soccer", Price = 19.50M },
            new Product { Name = "Corner flag", Category = "Soccer", Price = 34.95M }
        };

        public HomeController(IValueCalculator calcParam, IValueCalculator calc2)
        {
            calc = calcParam;
        }

        // GET: Home
        public ActionResult Index()
        {
            ShoppingCart cart = new ShoppingCart(calc) { Products = products };

            decimal totalValue = cart.CalculateProductTotal();

            return View(totalValue);
        }
    }
}