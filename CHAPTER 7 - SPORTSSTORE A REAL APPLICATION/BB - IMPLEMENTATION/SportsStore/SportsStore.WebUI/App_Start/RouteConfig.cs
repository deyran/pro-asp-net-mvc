using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SportsStore.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*
            EE ADDING PAGINATION
	            IMPROVING THE URLs
		            Listing 7-24. Adding a new route to the RouteConfig.cs file
             */
            routes.MapRoute(
                name: null,
                url: "Page{page}",
                defaults: new { Controller = "Product", action = "List" }
            );

            /*
            CC DISPLAYING A LIST OF PRODUCTS
	            SETTING THE DEFAULT ROUTE
		            Listing 7-10. Adding the Default Route in the RouteConfig.cs file.             
             */
            routes.MapRoute (
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Product",
                    action = "List",
                    id = UrlParameter.Optional
                }
            );
        }
    }
}


