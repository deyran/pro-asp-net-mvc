using System.Collections.Generic;
using System.Linq;

namespace EssentialTools.Models
{
    /*
    AA PREPEARING THE EXAMPLE PROJECT -> 120
    AAAA CREATING THE MODEL CLASS -> 120
    >> Listing 6-2. The contents of the LinqValueCalculators.cs file -> 121    
    */
    public class LinqValueCalculator
    {
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return products.Sum(p => p.Price);
        }
    }
}