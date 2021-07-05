using System.Collections.Generic;
using System.Linq;

namespace EssentialTools.Models
{
    /*
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
            System.Diagnostics.Debug.WriteLine(
                string.Format("Instance {0} created", ++counter);
            );
        }

        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return discounter.ApplyDiscount(products.Sum(p => p.Price));
        }
    }
}