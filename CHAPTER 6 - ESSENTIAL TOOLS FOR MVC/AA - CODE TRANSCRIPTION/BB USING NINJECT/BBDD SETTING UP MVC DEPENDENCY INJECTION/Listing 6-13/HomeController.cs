using System.Web.Mvc;
using EssentialTools.Models;

namespace EssentialTools.Controllers
{
    /*
    BB USING NINJECT -> 123
    BBDD SETTING UP MVC DEPENDENCY INJECTION -> 127
    >> REFACTORING THE HOME CONTROLLER -> 128
    >>>> Listing 6-13. Refactoring the controller in the HomeController.cs file -> 128
    */    
    public class HomeController : Controller
    {
        private IValueCalculator calculator;
        private Product[] products = 
        {
            new Product { Name = "Kayak", Category = "Watersports", Price = 275M },
            new Product { Name = "Lifejacket", Category = "Watersports", Price = 48.95M },
            new Product { Name = "Soccer ball", Category = "Soccer", Price = 19.50M },
            new Product { Name = "Corner flag", Category = "Soccer", Price = 34.95M }
        };

        public HomeController(IValueCalculator calcParam)
        {
            calc = calcParam;
        }

        public ActionResult Index()
        {
            ShoppingCart cart = new ShoppingCart(calc) { Products = products };

            decimal totalValue = cart.CalculateProductTotal();

            return View(totalValue);
        }
    }
}