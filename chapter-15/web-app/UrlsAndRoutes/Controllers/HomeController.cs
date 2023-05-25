using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    /*
    # Chapter 15: URL Routing

    ## Preparing the example project
    ### Creating the example controllers
    #### Listing 15-1. The contents of the HomeControllers.cs file

    ## Defining custom segment variables 389
    ### Listing 15-16. Accessing a custom variable in an action method in the HomeController.cs file
    */
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "Index";
            return View("ActionName");
        }

        public ActionResult CustomVariable()
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "CustomVariable";
            ViewBag.CustomVariable = RouteData.Values["id"];

            return View();
        }
    }
}