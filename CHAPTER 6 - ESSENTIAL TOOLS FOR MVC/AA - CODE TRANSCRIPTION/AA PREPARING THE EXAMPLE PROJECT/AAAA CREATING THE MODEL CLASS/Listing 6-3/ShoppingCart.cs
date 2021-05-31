using System.Collections.Generic;

namespace EssentialTools.Models
{
    /*
    AA PREPEARING THE EXAMPLE PROJECT -> 120
    AAAA CREATING THE MODEL CLASS -> 120
    >> Listing 6-3. The contents of the ShoppingCart.cs file -> 121
    */
    public class ShoppingCart
    {
        private LinqValueCalculator calc;
        public ShoppingCart(LinqValueCalculator calcParam)
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