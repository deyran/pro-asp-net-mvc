using System.ComponentModel.DataAnnotations;

namespace SportsStore.Domain.Entities
{
    /*
    SUBMITTING ORDERS
	    EXTENDING THE DOMAIN MODEL
		    Listing 9-8. The Contents of the ShippingDetails.cs File

	    ADDING THE CHECKOUT PROCESS
		    Listing 9-13. Applying th e Display attribute to the ShippingDetails.cs File
     */
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the first address line")]
        [Display(Name = "Line 1")]
        public string Line1 { get; set; }
        [Display(Name = "Line 2")]
        public string Line2 { get; set; }
        [Display(Name = "Line 3")]
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Please enter a city name")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a state name")]
        public string State { get; set; }

        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter a country name")]
        public string Country { get; set; }

        public bool GifWrap { get; set; }
    }
}