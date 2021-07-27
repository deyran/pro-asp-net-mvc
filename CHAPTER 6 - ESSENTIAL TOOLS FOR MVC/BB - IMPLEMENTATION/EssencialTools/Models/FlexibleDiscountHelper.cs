using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssencialTools.Models
{
    /*
    BB USING NINJECT -> 123
    BBGG USING CONDITIONAL BINDING -> 133
    >> Listing 6-21. The contents of the FlexibleDiscountHelper.cs file -> 133    
    */
    public class FlexibleDiscountHelper : IDiscountHelper
    {
        public decimal ApplyDiscount(decimal totalParam)
        {
            decimal discount = totalParam > 100 ? 70 : 25;
            return (totalParam - (discount / 100m * totalParam));
        }
    }
}