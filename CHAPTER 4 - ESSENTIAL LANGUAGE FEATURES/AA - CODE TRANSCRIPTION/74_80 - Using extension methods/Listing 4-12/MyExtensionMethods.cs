namespace LanguageFeature.Models
{
    /*
    >> USING EXTENSION METHODS - 74-80
    >>>> Listing 4-12 - Defining and extension method in the MyExtensionMethods.cs file
    */
    public static decimal TotalPrices(this ShoppingCart cartParam)
    {
        decimal total = 0;
        foreach(Product pro in cartParam.Products)
        {
            total += prod.Price;
        }

        return total;
    }
}