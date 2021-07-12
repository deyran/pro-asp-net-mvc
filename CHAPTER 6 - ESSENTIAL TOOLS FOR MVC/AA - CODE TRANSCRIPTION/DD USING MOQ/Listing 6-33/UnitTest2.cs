using EssentialTools.Models;
using Microsoft.VisualStudio.Testtools.UnitTesting;
using System.Linq;
using Moq;

namespace EssentialTools.Tests
{
    /*
    DD USING MOQ -> 145
    DDBB ADDING MOQ TO THE VISUAL STUDIO PROJECT -> 147
    DDCC A MOCK OBJECT TO A UNIT TEST -> 147
    >> Listing 6-33. Using a Mock object in a Unit Test in the UnitTest2.cs file -> 147    
    */
    [TestClass]
    public class UnitTest2
    {
        private Product[] products =
        {
            new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
            new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
            new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
            new Product {Name = "Corner flag", Category = "Soccer", Price = 94.95M},
        };

        [TestMethod]
        public void Sum_Products_Correctly()
        {
            // arrange
            Mock<IDiscountHelper> mock = new Mock<IDiscountHelper>();
            mock.Setup(m => m.ApplyDiscount(It.IsAny<decimal>()))
                .Returns<decimal>(total => total);
            var target = new LinqValueCalculator(mock.Object);

            // act
            var result = target.ValueProducts(products);

            // assert
            Assert.AreEqual(products.Sum(e => e.Price), result);
        }
    }
}