using System.Collections.Generic;
using System.Linq;

namespace EssentialTools.Models
{
    /*
    BB USING NINJECT -> 123
    BBEE CREATING CHAINS OF DEPENDENCY -> 130
    >> Listing 6-15. Adding a Dependency in the LinqValueCalculator.cs file -> 130
    */  
    public class LinqValueCalculator : IValueCalculator
    {
        private IDiscountHelper discounter;

        public LinqValueCalculator(IDiscountHelper discountParam)
        {
            discounter = discountParam;
        }

        public decimal ValueProducts(IEnumeable<Product> products)
        {
            return discounter.ApplyDiscount(products.Sum(p => p.Price));
        }
    }
}