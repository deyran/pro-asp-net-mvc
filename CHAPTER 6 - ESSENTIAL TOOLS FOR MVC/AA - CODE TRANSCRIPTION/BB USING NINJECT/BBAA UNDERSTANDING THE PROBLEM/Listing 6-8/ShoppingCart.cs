using System.Collections.Generic;

namespace EssentialTools.Models
{
    /*
    BB USING NINJECT -> 123
    BBAA UNDERSTANDING THE PROBLEM -> 123
    >> APPLYING AN INTERFACE -> 123
    >>>> Listing 6-8. Applying the interface in the ShoppingCart.cs -> 124

    AA PREPEARING THE EXAMPLE PROJECT -> 120
    AAAA CREATING THE MODEL CLASS -> 120
    >> Listing 6-3. The contents of the ShoppingCart.cs file -> 121
    */
    public class ShoppingCart
    {
        private IValueCalculator calc;        
        public ShoppingCart(IValueCalculator calcParam)
        {
            calc = calcParam;
        }
        public IEnumerable<Product> Products { get; set; }
        public decimal CalculateProductTotal()
        {
            return calc.ValueProducts(Products);
        }
    }    
}