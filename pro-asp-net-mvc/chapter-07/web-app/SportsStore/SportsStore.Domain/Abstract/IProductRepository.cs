using System.Collections.Generic;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Abstract
{
    /*
    # chapter-07-SportsStore-A-Real-Application
        ## Creating an abstract repository
            Listing 7-4. The Contents of the IProductRepository.cs File
     */
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}