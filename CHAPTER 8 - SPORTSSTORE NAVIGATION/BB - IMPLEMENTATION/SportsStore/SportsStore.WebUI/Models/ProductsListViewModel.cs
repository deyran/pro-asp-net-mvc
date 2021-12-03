using System.Collections.Generic;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Models
{
    /*
    ADDING PAGINATION
	    Adding the View Model data
		    Listing 7-20. The contents of the ProductsListViewModel.cs file
     */

    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}