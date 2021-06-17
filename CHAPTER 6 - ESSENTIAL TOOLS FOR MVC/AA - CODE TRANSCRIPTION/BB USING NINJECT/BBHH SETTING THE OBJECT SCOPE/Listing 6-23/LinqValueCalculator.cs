using System.Collections.Generic;
using System.Linq;

namespace EssentialTools.Models
{
    /*
    BB USING NINJECT -> 123
    BBHH SETTING THE OBJECT SCOPE -> 134
    >> Listing 6-23. Adding a construction in the LinqValueCalculator.cs file -> 134    
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