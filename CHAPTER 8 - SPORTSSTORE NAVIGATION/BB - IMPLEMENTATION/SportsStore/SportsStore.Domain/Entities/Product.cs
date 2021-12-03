
namespace SportsStore.Domain.Entities
{
    /*
     BB STARTING THE DOMAIN MODEL
        Listing 7-3. The Contents of the Products.cs file
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