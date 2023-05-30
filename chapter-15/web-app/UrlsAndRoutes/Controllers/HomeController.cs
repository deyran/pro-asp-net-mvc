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

    ### Using custom variables as action method parameters
    #### Listing 15-18. Adding an action method parameter in the HomeController.cs file

    ### Defining optional URL segments
    #### Listing 15-20. Checking for an Optional Segment Variable in the HomeController.cs file
    */
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "Index";
            return View("ActionName");
        }

        public ActionResult CustomVariable(string id)
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "CustomVariable";
            ViewBag.CustomVariable = id ?? "<no value>";

            return View();
        }
    }
}