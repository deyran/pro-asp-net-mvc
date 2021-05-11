using System.Collections;
using System.Collections.Generic;

namespace LanguageFeatures.Models
{
    /*
    >> USING EXTENSION METHODS -> 74-80
    >>>> Applying extension methods to an interface -> 76
    >>>>>>>> Listing 4-14 - Implementing an interface in the ShoppingCart.cs file -> 76    
    */
    
    public class ShoppingCart: IEnumerable<Product>
    {
        public List<Product> Products { get; set; }

        public IEnumerator<Product> GetEnumerator()
        {
            return Products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}