using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using System.Collections.Generic;

namespace SportsStore.Domain.Concrete
{
    /*
    DD PREPARING A DATABASE
	    CREATING THE PRODUCT REPOSITORY
		    Listing 7-14. The contents of the EFProductRepository.cs file
     */
    public class EFProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Product> Products => context.Products;
    }
}
