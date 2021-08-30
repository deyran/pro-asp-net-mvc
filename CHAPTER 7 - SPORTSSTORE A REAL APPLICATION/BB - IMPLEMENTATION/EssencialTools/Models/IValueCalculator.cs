using System.Collections.Generic;

namespace EssencialTools.Models
{
    /*
    BB USING NINJECT -> 123
    BBAA UNDERSTANDING THE PROBLEM -> 123
    >> APPLYING AN INTERFACE -> 123
    >>>> Listing 6-6. The contents of the IValueCalculator.cs file -> 123    
    */

    public interface IValueCalculator
    {
        decimal ValueProducts(IEnumerable<Product> products);
    }
}