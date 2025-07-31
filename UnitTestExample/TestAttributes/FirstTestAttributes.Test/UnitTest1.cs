using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FirstTestAttributes.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [Owner("Utku")] // Kim yazdı
        [TestCategory("Tester")]
        [Priority(3)] // Öncelik sırası
        [TestProperty("UpdatedBy", "Utku")] // Kendi gurbumuzu oluşturabiliriz
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("Utku")]
        [TestCategory("Tester")]
        [Priority(1)]
        [TestProperty("UpdatedBy", "Utku")]
        [TestProperty("UpdatedBy2", "Umut")]
        public void TestMethod2()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("Utku")]
        [TestCategory("Tester")]
        [TestCategory("Developer")]
        [TestCategory("Demo")]
        [TestProperty("UpdatedBy", "Umut")]
        [Priority(1)]
        public void TestMethod3()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("Utku")]
        [TestCategory("Developer")]
        [Priority(2)]
        public void TestMethod4()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("Umut")]
        [TestCategory("Developer")]
        [Priority(2)]
        public void TestMethod5()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
