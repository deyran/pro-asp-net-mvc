namespace Razor.Models
{
    /*
    >> PREPARING THE EXAMPLE PROJECT -> 95
    >>>> DEFINING THE MODEL -> 95
    >>>>>>>> Listing 5-1. The contents of the Products.cs file -> 96    
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