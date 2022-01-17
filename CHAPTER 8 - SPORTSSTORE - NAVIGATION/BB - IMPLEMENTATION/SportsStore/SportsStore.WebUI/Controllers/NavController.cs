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
    */
    public class NavController : Controller
    {
        private IProductRepository repository;

        public NavController(IProductRepository repo)
        {
            repository = repo;
        }

        public PartialViewResult Menu()
        {
            IEnumerable<string> categories = repository.Products
                                                .Select(x => x.Category)
                                                .Distinct()
                                                .OrderBy(x => x);

            return PartialView(categories);
        }
    }
}