using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCart.Test
{
    [TestClass]
    public class CarTest
    {
        private CartItem _cartItem;
        private CartManager _cartManager;


        [TestInitialize]
        public void TestInitialize()
        {
            // Her testten önce çalışıcak
            // Ortak olan nesneler yazılır
            _cartManager = new CartManager();
            _cartItem = new CartItem
            {
                Product = new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    UnitPrice = 2500
                },
                Quantity = 1
            };
            _cartManager.Add(_cartItem);

        }

        [TestMethod]
        public void Products_should_be_added_to_cart()
        {
            //Arrenge
            const int expected = 1;

            //Act
            var totalNumberOfElement = _cartManager.TotalItems;

            // Assert
            Assert.AreEqual(expected, totalNumberOfElement);
        }

        [TestMethod]
        public void Product_should_be_remove_from_cart()
        {
            // Arrange
            var totalNumberOfElement = _cartManager.TotalItems;

            //Act
            _cartManager.Remove(1);
            var numberOfRemainingProductCountFromCart = _cartManager.TotalItems;

            // Assert
            Assert.AreEqual(totalNumberOfElement - 1, numberOfRemainingProductCountFromCart);
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            // Her test methoddan sonra çalışıcak.
            _cartManager.Clear();
        }

        [TestMethod]
        public void Cart_should_be_deletable()
        {
            // Act
            _cartManager.Clear();

            // Assert
            Assert.AreEqual(0, _cartManager.TotalQuantity);
            Assert.AreEqual(0, _cartManager.TotalItems);
        }
    }
}
