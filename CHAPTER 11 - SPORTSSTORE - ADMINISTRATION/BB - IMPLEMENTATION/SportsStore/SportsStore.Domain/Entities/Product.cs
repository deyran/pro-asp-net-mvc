using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SportsStore.Domain.Entities
{
    /*
    BB STARTING THE DOMAIN MODEL
        Listing 7-3. The Contents of the Products.cs file

    CHAPTER 11 - SPORTSSTORE - ADMINISTRATION
        ADDING CATALOG MANAGEMENT
            EDITING PRODUCTS
                CREATE THE EDIT VIEW
                    Listing 11-7. Using Model Metadata in the Product.cs File
    */
    public class Product
    {
        [HiddenInput(DisplayValue = false)]
        public int ProductID { get; set; }
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}

