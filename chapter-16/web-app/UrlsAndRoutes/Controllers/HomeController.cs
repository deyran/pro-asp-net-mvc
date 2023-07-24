using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    /*
    # Chapter 16: Advanced routing features
    ## Generating outgoing URLs in Views
    ### Generating Outgoing URLs in action methods
    #### Listing 16-11. Generating an Outgoing URL in the HomeControlle.cs file
    #### Listing 16-12. Redirecting to another action in the HomeController.cs file
    #### Listing 16-13. Redirecting to a URL in the HomeController.cs file
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

        public RedirectToRouteResult MyActionMethod()
        {
            return RedirectToRoute(
                new
                {
                    controller = "Home",
                    action = "Index",
                    id = "MyID"
                }
            );
        }
        public RedirectToRouteResult MyActionMethod2()
        {
            return RedirectToAction("Index");
        }
    }
}