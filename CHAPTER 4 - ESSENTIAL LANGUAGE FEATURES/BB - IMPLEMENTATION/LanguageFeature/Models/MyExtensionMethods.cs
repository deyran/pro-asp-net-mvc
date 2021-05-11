using LanguageFeature.Models;
using System.Collections.Generic;

namespace LanguageFeature.Models
{
	/*
	>> USING EXTENSION METHODS -> 74-80
    >>>> Applying extension methods to an interface -> 76
    >>>>>>>> Listing 4-15 - An Extension method that works on an interface in the MyExtensionMethods.cs file -> 76 
	 */
	public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this IEnumerable<Product> productEnum)
		{
			decimal total = 0;
			foreach (Product prod in productEnum)
			{
                total += prod.Price;
			}

			return total;
		}
	}
}