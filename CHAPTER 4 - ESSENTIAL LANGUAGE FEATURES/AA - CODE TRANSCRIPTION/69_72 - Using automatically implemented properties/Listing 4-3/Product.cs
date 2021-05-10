namespace LanguageFeatures.Models
{
    /*
    >> USING AUTOMATICALLY IMPLEMENTED PROPERTIES
    >>>> Listing 4-3. Defining a property in the Product.cs file (page 69)
    */
    public class Product
    {
        private string name;

        public string Name
        {
            get { return name; }
            set {name = value; }
        }
    }
}