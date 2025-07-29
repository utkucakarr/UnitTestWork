using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Helpers.Tests
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void Remove_extra_spaces_from_beginning_and_end_of_entered() // Method adı gereksinim ne ise onun adı olması
        {
            // Arrange
            var expression = " Utku Çakar ";
            var expected = "Utku Çakar";

            // Act
            var occurred = StringHelper.DeleteExtraSpaces(expression);

            // Assert
            Assert.AreEqual(expected, occurred); // İki değer birbirine eşit ise test geçerli demektir
        }

        [TestMethod]
        public void Remove_extra_spaces_in_expression_entered()
        {
            // Arrange
            var expression = "Utku Çakar   Umut   Çakar   ";
            var expected = "Utku Çakar Umut Çakar";

            // Act
            var occurred = StringHelper.DeleteExtraSpaces(expression);

            // Assert
            Assert.AreEqual(expected, occurred); // İki değer birbirine eşit ise test geçerli demektir
        }
    }
}
