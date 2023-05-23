using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using SportsStore.WebUI.Models;

namespace SportsStore.WebUI.Controllers
{
    /*
    DISPLAYING A LIST OF PRODUCTS
	    ADDING A CONTROLLER
		    Listing 7-6. The initial contents of the <b>ProductController.cs</b> file
		    Listing 7-7. Adding an action method to the ProductController.cs file

    ADDING PAGINATION
	    Listing 7-16. Adding pagination support to the list action method in the ProductController.cs file

	    Adding the View Model data
		    Listing 7-21. Updating the list method in the ProductController.cs file

    ADDING NAVIGATION CONTROLS
	    Filtering the Product List
		    Listing 8-2. Adding category support to the List action method in the ProductController.cs file

	    CORRECTING THE PAGE COUNT
		    Listing 8-11. Creating Category-Aware Pagination Data in the ProductController.cs File


    CHAPTER 12 - SportsStore: Security & Finishing Touches
        # Image Uploads 
            ## Implementing the GetImage Action Method
                Listing 12-14. The GetImage Action Method in the ProductController.cs File
    */
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 4;

        public ProductController(IProductRepository productRepository)
        {
            this.repository = productRepository;
        }
        public ViewResult List(string category, int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = repository.Products
                                .Where(p => category == null || p.Category == category)
                                .OrderBy(p => p.ProductID)
                                .Skip((page - 1) * PageSize)
                                .Take(PageSize)
                ,
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,

                    TotalItems = category == null ?
                                    repository.Products.Count() :
                                    repository.Products.Where(e => e.Category == category).Count()

                },

                CurrentCategory = category
            };

            return View(model);
        }

        public FileContentResult GetImage(int productId)
        {
            Product product = repository.Products.FirstOrDefault(p => p.ProductID == productId);

            if (product != null)
            {
                return File(product.ImageData, product.ImageMimeType);
            }
            else
            {
                return null;
            }
        }
    }
}