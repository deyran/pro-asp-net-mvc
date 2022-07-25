using System.Collections.Generic;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using System.Linq;

namespace SportsStore.WebUI.Controllers
{
    /*
    ADDING NAVIGATION CONTROLS
        BUILDING A CATEGORY NAVIGATION MENU
            CREATING THE NAVIGATION CONTROLLER
                Listing 8-5. Adding the Menu action method to the NavController.cs file

            GENERATING CATEGORY LISTS
                Listing 8-7. Implementing the Menu Method in the NavController.cs File

		    HIGHLIGHTING THE CURRENT CATEGORY
			    Listing 8-9. Using the View Bag Feature in the NavController.cs File


    CHAPTER 10 - SPORTSSTORE MOBILE
	    USING RESPONSIVE DESIGN
		    CREATING A RESPONSIVE PRODUCT LIST
			    HELPING THE CONTROLLER SELECT A VIEW
				    Listing 10-5. Updating the Menu Action Method in the NavController.cs File

			    REMOVING VIEW DUPLICATION
				    Listing 10-8. Updating the Menu Action in the NavController.cs File

	    CREATING MOBILE SPECIFIC CONTENT
		    CREATING THE MOBILE VIEWS
			    Listing 10-10A. The Contents of the NavControlle.cs File
    */

    public class NavController : Controller
    {
       private readonly IProductRepository repository;

         public NavController(IProductRepository repo) => repository = repo;

        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;

            IEnumerable<string> categories = repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return PartialView("FlexMenu", categories);
        }
    }
}

