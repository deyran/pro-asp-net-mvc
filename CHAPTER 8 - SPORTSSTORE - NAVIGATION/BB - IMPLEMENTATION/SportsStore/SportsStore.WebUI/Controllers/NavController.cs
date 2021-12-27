using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers
{
    /*
    ADDING NAVIGATION CONTROLS
	    BUILDING A CATEGORY NAVIGATION MENU
		    CREATING THE NAVIGATION CONTROLLER
			    Listing 8-5. Adding the Menu action method to the NavController.cs file
     */
    public class NavController : Controller
    {
        public string Menu()
        {
            return "Hello from NavController";
        }
    }
}