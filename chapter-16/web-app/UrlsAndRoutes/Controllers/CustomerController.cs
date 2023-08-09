using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    /*
    # Chapter 16: Advanced routing features
    ## Generating outgoing URLs in Views
    ### Generating a URL from a specific route
    #### Listing 16-15. Naming a Route in the CustomerController.cs file
     */

    public class CustomerController : Controller
    {
        [Route("~/Test")]
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

        [Route("Add/{user}/{id:int}", Name = "AddRoute")]
        public string Create(string user, int id)
        {
            return string.Format("Create Method - User: {0}, ID: {1}", user, id);
        }
    }
}