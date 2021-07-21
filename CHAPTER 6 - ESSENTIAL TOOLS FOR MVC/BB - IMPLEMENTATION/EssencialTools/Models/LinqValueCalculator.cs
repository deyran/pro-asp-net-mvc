using System.Collections.Generic;
using System.Linq;

namespace EssencialTools.Models
{
    /*
    AA PREPEARING THE EXAMPLE PROJECT -> 120
    AAAA CREATING THE MODEL CLASS -> 120
    >> Listing 6-2. The contents of the LinqValueCalculators.cs file -> 121

    BB USING NINJECT -> 123
    BBAA UNDERSTANDING THE PROBLEM -> 123
    >> APPLYING AN INTERFACE -> 123
    >>>> Listing 6-7. Applying an interface in the LinqValueCalculator.cs file -> 124    
    */
    public class LinqValueCalculator: IValueCalculator
    {
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return products.Sum(p => p.Price);
        }
    }
}