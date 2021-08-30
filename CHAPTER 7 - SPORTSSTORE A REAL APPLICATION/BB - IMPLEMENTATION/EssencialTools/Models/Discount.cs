namespace EssencialTools.Models
{
    /*
    BB USING NINJECT -> 123
        BBEE CREATING CHAINS OF DEPENDENCY -> 130
            >> Listing 6-14. The contents of the Discount.cs file -> 130

        BBFF SPECIFYING PROPERTY AND CONSTRUCTOR PARAMETER VALUES -> 131
            >> Listing 6-17. Adding a property in the Discount.cs file -> 131

        BBFF SPECIFYING PROPERTY AND CONSTRUCTOR PARAMETER VALUES -> 131
            >> Listing 6-19. Using a constructor property in the Discount.cs file -> 132
    */

    public interface IDiscountHelper
    {
        decimal ApplyDiscount(decimal totalParam);
    }

    public class DefaultDiscountHelper : IDiscountHelper
    {
        public decimal discountSize { get; set; }

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