using System.Web.Mvc;
using System.Web.Routing;

namespace SportsStore.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            /*
            CC DISPLAYING A LIST OF PRODUCTS
	            SETTING THE DEFAULT ROUTE
		            Listing 7-10. Adding the Default Route in the RouteConfig.cs file.

            EE ADDING PAGINATION
	            IMPROVING THE URLs
		            Listing 7-24. Adding a new route to the RouteConfig.cs file

            ADDING NAVIGATION CONTROLS
	            FILTERING THE PRODUCT LIST
		            REFINING THE URL SCHEME
			            Listing 8-3. The new URL scheme in the RouteConfig.cs file
             */

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                null,
                 "",
                 new { controller = "Product", action = "List", category = (string)null, page = 1 }
             );

            routes.MapRoute(
                null,
                "Page{page}",
                new { controller = "Product", action = "List", category = (string)null },
                new { page = @"\d+" }
            );

            routes.MapRoute(
                null,
                "{category}",
                new { controller = "Product", action = "List", page = 1 }
            );

            routes.MapRoute(
                null,
                "{category}/Page{page}",
                new { controller = "Product", action = "List" },
                new { page = @"\d+" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}