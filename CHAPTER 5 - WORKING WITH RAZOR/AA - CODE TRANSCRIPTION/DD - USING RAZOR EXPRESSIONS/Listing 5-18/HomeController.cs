using System.Web.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    /*
    >> USING RAZOR EXPRESSIONS -> 107
    >>>> INSERTING DATA VALUES -> 107
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

        // ... other action methods omitted for brevity...

        public ActionResult DemoArray()
        {
            Product[] array =
            {
                new Product { Name = "Kayak", Price = 275M },
                new Product { Name = "Lifejacket", Price = 48.95M },
                new Product { Name = "Soccer ball", Price = 19.50M },
                new Product { Name = "Corner flag", Price = 34.95M }
            };

            return View(array);
        }
    }
}