using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using System.Collections.Generic;

namespace SportsStore.Domain.Concrete
{
    /*
    DD PREPARING A DATABASE
	    CREATING THE PRODUCT REPOSITORY
		    Listing 7-14. The contents of the EFProductRepository.cs file

    CHAPTER 11 - SPORTSSTORE - ADMINISTRATION
        ADDING CATALOG MANAGEMENT
            UPDATING THE PRODUCT REPOSITORY
                Listing 11-10. Implementing the SaveProduct Method in the EFProductRepository.cs File
    */
    public class EFProductRepository : IProductRepository
    {
        private readonly EFDbContext context = new EFDbContext();
        public IEnumerable<Product> Products => context.Products;

        public void SaveProduct(Product product)
        {
            if (product.ProductID == 0)
            {
                context.Products.Add(product);
            }
            else
            {
                Product dbEntry = context.Products.Find(product.ProductID);
                if (dbEntry != null)
                {
                    dbEntry.Name = product.Name;
                    dbEntry.Description = product.Description;
                    dbEntry.Price = product.Price;
                    dbEntry.Category = product.Category;
                }
            }

            context.SaveChanges();
        }
    }
} 

