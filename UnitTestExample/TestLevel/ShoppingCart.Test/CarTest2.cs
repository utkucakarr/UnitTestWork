using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCart.Test
{
    [TestClass]
    public class CarTest2
    {
        private static CartManager _cartManager;
        private static int id = 0;

        [ClassInitialize]
        public static void ClassIni(TestContext testContext)
        {
            _cartManager = new CartManager();
        }
        

        [TestMethod]
        public void MyIntegratonTestLikeUnitTest()
        {
            When_product_is_added_to_cart_number_of_items_should_increase_by_one();

            When_product_is_removed_to_cart_number_of_items_should_decrease_by_one();

            When_cart_is_cleared_there_should_be_no_items_left_in_cart();
        }

        private static void When_product_is_added_to_cart_number_of_items_should_increase_by_one()
        {
            var quantity = _cartManager.TotalQuantity;

            id++;
            _cartManager.Add(new CartItem
            {
                Product = new Product
                {
                    ProductId = id,
                    ProductName = "Laptop",
                    UnitPrice = 2500
                },
                Quantity = 1,
            });

            Assert.AreEqual(quantity + 1, _cartManager.TotalQuantity);
        }

        private static void When_product_is_removed_to_cart_number_of_items_should_decrease_by_one()
        {
            var quantity = _cartManager.TotalQuantity;

            _cartManager.Remove(id);
            id--;

            Assert.AreEqual(quantity - 1, _cartManager.TotalQuantity);
        }

        private static void When_cart_is_cleared_there_should_be_no_items_left_in_cart()
        {
            _cartManager.Clear();

            Assert.AreEqual(0, _cartManager.TotalItems);
            Assert.AreEqual(0, _cartManager.TotalQuantity);
        }
    }
}
