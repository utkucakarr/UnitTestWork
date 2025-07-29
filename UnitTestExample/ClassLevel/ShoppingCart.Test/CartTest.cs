using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCart.Test
{
    [TestClass]
    public class CartTest
    {
        private static CartItem _cartItem;
        private static CartManager _cartManager;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            // Test class için ilk çalışır. Statik olmak zorunda. TestContext tipinde parametre almalı
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

        [ClassCleanup]
        public static void ClassCleanup()
        {
            // Test class için en son çalışır.
            _cartManager.Clear();
        }

        [TestMethod]
        public void When_different_product_added_cart_total_number_and_element_number_must_increase_one()
        {
            // Arrange
            int totalAmount = _cartManager.TotalQuantity;
            int totalElementNumber = _cartManager.TotalItems;

            // Act
            _cartManager.Add(new CartItem
            {
                Product = new Product
                {
                    ProductId = 2,
                    ProductName = "Mouse",
                    UnitPrice = 2500
                },
                Quantity = 1
            });

            // Assert
            Assert.AreEqual(totalAmount + 1, _cartManager.TotalQuantity);
            Assert.AreEqual(totalElementNumber + 1, _cartManager.TotalItems);
        }

        [TestMethod]
        public void When_product_added_cart_total_product_should_increase_one_and_number_of_elements_should_remain_same()
        {
            // Arrange
            int totalAmount = _cartManager.TotalQuantity;
            int totalElementNumber = _cartManager.TotalItems;

            // Act
            _cartManager.Add(_cartItem);

            // Assert
            Assert.AreEqual(totalAmount + 1, _cartManager.TotalQuantity);
            Assert.AreEqual(totalElementNumber, _cartManager.TotalItems);
        }
    }
}