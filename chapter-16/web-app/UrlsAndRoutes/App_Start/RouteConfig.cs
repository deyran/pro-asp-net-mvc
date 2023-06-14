using System.Web.Mvc;
using System.Web.Routing;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        /*
        # Chapter 16: Advanced routing features
        ## Preparing the example project
        ### Listing 16-1. Simplifying the example routes in the RouteConfig.cs file

        ### Using the routing system to generate an outgoing URL
        #### Listing 16-3. Adding a route to the RouteConfig.cs file
        */

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes();

            routes.MapRoute
            (
                "NewRoute",
                "App/Do{action}",
                new { controller = "Home" }
            );

            routes.MapRoute
            (
                "MyRoute",
                "{controller}/{action}/{id}",
                new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );
        }
    }
}