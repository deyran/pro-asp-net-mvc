namespace EssentialTools.Models
{
    /*
    BB USING NINJECT -> 123
    BBEE CREATING CHAINS OF DEPENDENCY -> 130
    >> Listing 6-14. The contents of the Discount.cs file -> 130    
    */
    public interface IDiscountHelper
    {
        decimal ApplyDiscount(decimal totalParam);
    }
    public class DefaultDiscountHelper : IDiscountHelper
    {
        public decimal ApplyDiscount(decimal totalParam)
        {
            return (totalParam - (10m / 100m * totalParam));
        }
    }
}