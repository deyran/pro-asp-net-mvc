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
    */
    public class ProductController : Controller
    {
        private IProductRepository repository;

        public ProductController(IProductRepository productRepository)
        {
            this.repository = productRepository;
        }
    }
}