using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    /*
    # Chapter 15: URL Routing
        ## Preparing the example project
            ### Creating the example controllers
                Listing 15-2. The contents of the CustomerController.cs file
     */
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "Index";
            return View("ActionName");
        }

        public ActionResult List()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "List";
            return View("ActionName");
        }
    }
}