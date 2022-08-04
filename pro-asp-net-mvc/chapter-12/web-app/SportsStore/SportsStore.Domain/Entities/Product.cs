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

                ADDING MODEL VALIDATION 294
                    Listing 11-13. Applying Validation Attributes to the Product.cs File
    */
    public class Product
    {
        [HiddenInput(DisplayValue = false)]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Please enter a product name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please specify a category")]
        public string Category { get; set; }
    }
}

