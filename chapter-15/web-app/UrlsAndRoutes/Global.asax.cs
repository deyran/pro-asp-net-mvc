using System.Web.Mvc;
using System.Web.Routing;

namespace UrlsAndRoutes
{
    public class MvcApplication : System.Web.HttpApplication
    {
        /*
        # Chapter 15: URL Routing
        ## Creating and registering a simple route
        ### Listing 15-6. The Defaiult Contents of the Global.asax.cs file         
         */

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
