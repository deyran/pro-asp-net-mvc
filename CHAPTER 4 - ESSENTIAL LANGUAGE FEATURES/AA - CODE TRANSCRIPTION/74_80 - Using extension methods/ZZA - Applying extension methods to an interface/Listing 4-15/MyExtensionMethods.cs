using System.Collections.Generic;

namespace LanguageFeatures.Models
{
    /*
    >> USING EXTENSION METHODS -> 74-80
    >>>> Applying extension methods to an interface -> 76
    >>>>>>>> Listing 4-15 - An Extension method that works on an interface in the MyExtensionMethods.cs file -> 76    
    */
    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this IEnumerable<Product> producEnum)
        {
            decimal total = 0;
            foreach(Product prod in producEnum)
            {
                total += prod.Price;
            }
            return total;
        }
    }
}