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

        ## Generating outgoing URLs in Views
        ### Passing extra values
        #### Listing 16-7. Listing 16-7. Editing the routes in the RouteConfig.cs file

        ### Generating a URL from a specific route
        #### Listing 16-14. Changing the route configuration in the RouteConfig.cs file
        */

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes();
            routes.MapRoute("MyRoute", "{controller}/{action}");
            routes.MapRoute("MyOtherRoute", "App/{action}", new { controller = "Home" });
        }
    }
}