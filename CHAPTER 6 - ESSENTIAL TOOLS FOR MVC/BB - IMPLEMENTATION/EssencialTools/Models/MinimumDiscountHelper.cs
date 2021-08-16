using System;

namespace EssencialTools.Models
{
    /*
    CC UNIT TESTING WITH VISUAL STUDIO -> 137
        >> Listing 6-26. The contents of the MinimumDiscountHelper.cs -> 137

    CCCC RUNNING THE UNIT TESTS (AND FAILING) -> 142
        >> IMPLEMENTING THE FEATURE -> 143
            >>>> Listing 6-29. The contents of the MinimumDiscountHelper.cs file -> 143
    */
    public class MinimumDiscountHelper : IDiscountHelper
    {
        public decimal ApplyDiscount(decimal totalParam)
        {
            if (totalParam < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (totalParam > 100)
            {
                return totalParam * 0.9M;
            }
            else if (totalParam > 10 && totalParam <= 100)
            {
                return totalParam - 5;
            }
            else
            {
                return totalParam;
            }
        }
    }
}