using System;

namespace SportsStore.WebUI.Models
{
    /*
    EE ADDING PAGINATION
	    Adding the View Model
		    Listing 7-17. The contents of the PagingInfo.cs file
    */
    public class PagingInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages
        {
            get
            {
                return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
            }
        }
    }
}

