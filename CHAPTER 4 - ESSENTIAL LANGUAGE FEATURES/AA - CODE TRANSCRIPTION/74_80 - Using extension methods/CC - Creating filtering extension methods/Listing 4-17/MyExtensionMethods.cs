using System.Collections.Generic;

namespace LanguageFeatures.Models
{
    /*
    >> USING EXTENSION METHODS -> 74-80
    >>>> Creating filtering extension methods -> 79
    >>>>>>>> Listing 4-17 - A filtering extension method in the MyExtensionMethods.cs file -> 79    
    */
    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this IEnumerable<Product> productEnum)
        {
            decimal total = 0;
            foreach(Product prod in productEnum)
            {
                total += prod.Price;
            }
            return total;
        }
    
        public static IEnumerable<Product> FilterByCategory(this IEnumerable<Product> productEnum, string categoryParam)
        {
            foreach (Product prod in productEnum)
            {
                if (prod.Category == categoryParam)
                {
                    yield return prod;
                }
            }
        }
    }
}