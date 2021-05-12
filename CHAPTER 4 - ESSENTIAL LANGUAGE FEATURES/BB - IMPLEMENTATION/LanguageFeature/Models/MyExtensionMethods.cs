using System;
using LanguageFeature.Models;
using System.Collections.Generic;

namespace LanguageFeature.Models
{
	/*
	>> USING LAMBDA EXPRESSIONS -> 80-84
	>>>> Listing 4-19. Using delegate in an extendion method in the MyExtensionMethods.cs file -> 80    
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

        public static IEnumerable<Product> Filter(this IEnumerable<Product> productEnum, Func<Product, bool> selectorParam)
		{ 
			foreach(Product prod in productEnum)
			{
				if(selectorParam(prod))
				{
					yield return prod;
				}
			}
		}
	}
}