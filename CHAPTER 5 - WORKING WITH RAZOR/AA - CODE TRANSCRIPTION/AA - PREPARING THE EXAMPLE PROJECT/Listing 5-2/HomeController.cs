using System.Web.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    /*
    >> PREPARING THE EXAMPLE PROJECT -> 95
    >>>> DEFINING THE MODEL -> 95
    >>>>>>>> Listing 5-2. The content of the HomeController file -> 96    
    */
    public class HomeController : Controller
    {
        Product myProduct = new Product
        {
            ProductID = 1,
            Name = "Kayak",
            Description = "A boar for one person",
            Category = "Watersports",
            Price = 275M
        };
        public ActionResult Index()
        {
            return View(myProduct); 
        }        
    }
}