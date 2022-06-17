using System.Web.Mvc;
using SportsStore.Domain.Abstract;

using System.Linq;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Controllers
{
    /*
    CHAPTER 11 - SPORTSSTORE - ADMINISTRATION
        ADDING CATALOG MANAGEMENT
            CREATING A CRUD CONTROLLER
                Listing 11-1. The Contents of the AdminController.cs File

            EDITING PRODUCTS
                CREATING THE EDIT ACTION METHOD
                    Listing 11-5. Adding the Edit Action Method in the AdminController.cs File
     */

    public class AdminController : Controller
    {
        private IProductRepository repository;

        public AdminController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View(repository.Products);
        }

        public ViewResult Edit(int productId)
        {
            Product product = repository.Products.FirstOrDefault(p => p.ProductID == productId);
            return View(product);
        }
    }
}