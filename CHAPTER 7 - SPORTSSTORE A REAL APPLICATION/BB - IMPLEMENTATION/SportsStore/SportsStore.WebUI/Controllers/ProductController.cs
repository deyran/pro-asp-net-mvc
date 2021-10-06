using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Controllers
{
    /*
    CC DISPLAYING A LIST OF PRODUCTS
	    ADDING A CONTROLLER
		    Listing 7-6. The initial contents of the <b>ProductController.cs</b> file
		    Listing 7-7. Adding an action method to the ProductController.cs file
    */
    public class ProductController : Controller
    {
        private IProductRepository repository;

        public ProductController(IProductRepository productRepository)
        {
            this.repository = productRepository;
        }
        public ViewResult List()
        {
            return View(repository.Products);
        }
    }
}