using System.Web.Mvc;
using System.Web.Routing;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        /*
        # Chapter 15: URL Routing
        ## Creating and registering a simple route
        ### Listing 15-5. The Default contents of the RouteConfig.cs file
        ### Listing 15-7. Registering a route in the RouteConfig.cs file
         */

        public static void RegisterRoutes(RouteCollection routes)
        {
            Route myRoute = new Route("{controller}/{action}", new MvcRouteHandler());
            routes.Add("MyRoute", myRoute);
        }
    }
}