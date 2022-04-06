using System.Collections.Generic;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Models
{
    /*
    ADDING PAGINATION
	    Adding the View Model data
		    Listing 7-20. The contents of the ProductsListViewModel.cs file

    Adding Navigation Controls
	    Filtering the Product List
		    Listing 8-1. Enhancing the ProductsListView.cs file */

    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}