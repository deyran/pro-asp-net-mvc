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
        ### Listing 15-8. Registering a Route using the MapRoute method in the RouteConfig.cs file

        ## Defining default values
        ### Listing 15-9. Providing a default value in the RouteConfig.cs file
        ### Listing 15-10. Providing action and controller default values in the RouteConfig.cs file

        ## Using static URL segments
        ### Listing 15-11. A URL pattern with static segments in the RouteConfig.cs file
        ### Listing 15-12. A URL Pattern with a Mixed segment in the RouteConfig.cs file
        */

        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.MapRoute(
                "",
                "X{controller}/{action}",
                new { controller = "Home", action = "Index" }
            );

            routes.MapRoute(
                "MyRoute",
                "{controller}/{action}",
                new { controller = "Home", action = "Index" }
            );

            routes.MapRoute(
                "",
                "Public/{controller}/{action}",
                new { controller = "Home", action = "Index" }
            );
        }
    }
}