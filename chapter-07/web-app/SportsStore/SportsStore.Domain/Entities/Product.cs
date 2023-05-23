namespace SportsStore.Domain.Entities
{
    /*
    # chapter-07-SportsStore-A-Real-Application
        ## Starting the domain model
            Listing 7-3. The Contents of the Product.cs File
     */
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}