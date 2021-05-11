
namespace LanguageFeature.Models
{
    /*
    >> USING AUTOMATICALLY IMPLEMENTED PROPERTIES
    >>>> Listing 4-7. Reverting from an automatic to a regular property in the Product.cs file
    */
    public class Product
    {
        private string name;
        public int ProductID { get; set; }
        public string Name
        {
            get { return ProductID + name; }
            set { name = value; }
        }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { set; get; }

    }
}