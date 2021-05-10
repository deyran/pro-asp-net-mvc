namespace LanguageFeature.Models
{
    /*
    >> USING AUTOMATICALLY IMPLEMENTED PROPERTIES
    >>>> Listing 4-5. Verbose property definitions in the Product.cs file
    */
    public class Product
    {
        private int productID;
        private string name;
        private string description;
        private decimal price;
        private string category;
        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }    
}