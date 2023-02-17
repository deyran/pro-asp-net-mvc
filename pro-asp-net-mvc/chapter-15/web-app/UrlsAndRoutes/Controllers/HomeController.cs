using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    /*
    # Chapter 15: URL Routing
        ## Preparing the example project
            ### Creating the example controllers
                Listing 15-1. The contents of the HomeControllers.cs file
    */
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "Index";
            return View("ActionName");
        }
    }
}