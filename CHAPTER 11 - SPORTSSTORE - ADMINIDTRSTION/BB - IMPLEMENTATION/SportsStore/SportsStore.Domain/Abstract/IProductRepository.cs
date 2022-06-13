using System.Collections.Generic;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Abstract
{
    /*
    BB STARTING THE DOMAIN MODEL
	    CREATING AN ABSTRACT REPOSITORY
		    Listing 7-4. The contents of the IProductRepository.cs file.
     */

    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
