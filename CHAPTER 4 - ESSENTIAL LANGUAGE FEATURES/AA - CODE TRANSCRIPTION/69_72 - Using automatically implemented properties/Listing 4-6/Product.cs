    namespace LanguageFeature.Models
    {
        /*
        >> USING AUTOMATICALLY IMPLEMENTED PROPERTIES
        >>>> Listing 4-6. Using automatically implemented properties in the Product.cs file
        */
        public class Product
        {
            public int ProductID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
            public string Category { set; get; }
        }
    }