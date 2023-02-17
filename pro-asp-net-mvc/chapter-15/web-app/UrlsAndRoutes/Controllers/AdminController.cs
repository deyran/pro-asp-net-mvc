using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    /*
    # Chapter 15: URL Routing
        ## Preparing the example project
            ### Creating the example controllers
                Listing 15-3. The contents of the AdminController.cs file     
     */
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "Index";
            return View("ActionName");
        }
    }
}