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
            
        BBEE CREATING CHAINS OF DEPENDENCY -> 130
            >> Listing 6-15. Adding a Dependency in the LinqValueCalculator.cs file -> 130

        BBHH SETTING THE OBJECT SCOPE -> 134
            >> Listing 6-23. Adding a construction in the LinqValueCalculator.cs file -> 134

    DD USING MOQ -> 145
        DDAA UNDERSTANDING THE PROBLEM -> 146
            >> Listing 6-31. The contents of the LinqValueCalculator.cs file -> 146    
    */
    public class LinqValueCalculator : IValueCalculator
    {
        private IDiscountHelper discounter;
        private static int counter = 0;

        public LinqValueCalculator(IDiscountHelper discountParam)
        {
            discounter = discountParam;
            System.Diagnostics.Debug.WriteLine(string.Format("Instance {0} created", ++counter));
        }
        
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return discounter.ApplyDiscount(products.Sum(p => p.Price));
        }
    }
}