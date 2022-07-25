using SportsStore.Domain.Entities;
using System.Data.Entity;

namespace SportsStore.Domain.Concrete
{
    /*
     DD PREPARING A DATABASE
        CREATING THE ENTITY FRAMEWORK CONTEXT
            Create a context class
                Listing 7-12. The content of the EFDbContext.cs file
     */

    class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
