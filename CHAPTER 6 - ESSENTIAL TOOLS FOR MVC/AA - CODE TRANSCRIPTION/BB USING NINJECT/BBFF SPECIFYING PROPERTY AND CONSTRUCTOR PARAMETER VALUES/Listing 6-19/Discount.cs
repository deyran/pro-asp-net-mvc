namespace EssentialTools.Models
{
    /*
    BB USING NINJECT -> 123
    BBFF SPECIFYING PROPERTY AND CONSTRUCTOR PARAMETER VALUES -> 131
    >> Listing 6-19. Using a constructor property in the Discount.cs file -> 132
    */
    public interface IDiscountHelper
    {
        decimal ApplyDiscount(decimal totalParam);
    }

    public class DefaultDiscountHelper : IDiscountHelper
    {
        public decimal discountSize;
        public DefaultDiscountHelper(decimal discountParam)
        {
            discountSize = discountParam;
        }
        public decimal ApplyDiscount(decimal totalParam)
        {
            return (totalParam - (discountSize / 100m * totalParam));
        }
    }
}