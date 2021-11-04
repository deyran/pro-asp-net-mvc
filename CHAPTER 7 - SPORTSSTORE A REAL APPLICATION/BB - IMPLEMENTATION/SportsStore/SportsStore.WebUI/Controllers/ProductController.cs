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

    ADDING PAGINATION
	    Listing 7-16. Adding pagination support to the list action method in the ProductController.cs file
    */
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 4;

        public ProductController(IProductRepository productRepository)
        {
            this.repository = productRepository;
        }
        public ViewResult List(int page = 1)
        {
            return (
                (ViewResult) repository.Products
                    .OrderBy(p => p.ProductID)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize)
            );
        }
    }
}

