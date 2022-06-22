using System.Collections.Generic;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Abstract
{
    /*
    BB STARTING THE DOMAIN MODEL
	    CREATING AN ABSTRACT REPOSITORY
		    Listing 7-4. The contents of the IProductRepository.cs file.

    CHAPTER 11 - SPORTSSTORE - ADMINISTRATION
        ADDING CATALOG MANAGEMENT
            UPDATING THE PRODUCT REPOSITORY
                Listing 11-9. Adding a Method to the IProductRespository.cs File
     */

    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        void SaveProduct(Product products);
    }
}