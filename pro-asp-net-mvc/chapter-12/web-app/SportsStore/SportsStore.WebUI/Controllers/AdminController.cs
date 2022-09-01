﻿using System.Web.Mvc;
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

            HANDLING EDIT POST REQUESTS
                Listing 11-11. Adding the POST-Handling Edit Action Method in the AdminController.cs File

            CREATING NEW PRODUCTS - 297
                Listing 11-16. Adding the Create Action Method to the AdminController.cs File

            DELETING PRODUCTS - 300
                Listing 11-20. The Delete Action Method in the AdminController.cs File

    chapter 12 - SportsStore: Security & Finishing Touches
        Securing the Administration Controller
            Applying Authorization with Filters
                Listing 12-3. Adding the Authorize Attribute in the AdminController.cs File
     */

    //[Authorize]
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

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                repository.SaveProduct(product);
                TempData["message"] = string.Format("{0} has been saved", product.Name);
                return RedirectToAction("/Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(product);
            }
        }

        [HttpPost]
        public ActionResult Delete(int productId)
        {
            Product deletedProduct = repository.DeleteProduct(productId);
            if (deletedProduct != null)
            {
                TempData["message"] = string.Format("{0} was deleted", deletedProduct.Name);
            }
            return RedirectToAction("/Index");
        }

        public ViewResult Create()
        {
            return View("Edit", new Product());
        }
    }
}