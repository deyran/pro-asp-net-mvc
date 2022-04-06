using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Models
{
    /*
    BUILDING THE SHOPPING CART
	    DISPLAYING THE CONTENTS OF THE CART
		    Listing 8-15. The Contents of the CartIndexViewModel.cs File
     */

    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}