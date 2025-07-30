using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestContextDemo.Test
{
    [TestClass]
    public class UnitTest1
    {
        // Runtime'da kendisi set olan bir nesne
        public TestContext TestContext { get; set; }


        [TestInitialize]
        public void TestInitialize()
        {
            TestContext.WriteLine("--TestInitialize--\n");
            TestContext.WriteLine("Test Adı: {0}", TestContext.TestName);
            TestContext.WriteLine("Test Durumu: {0}", TestContext.CurrentTestOutcome);
            TestContext.WriteLine("Test Sınıfı: {0}", TestContext.FullyQualifiedTestClassName);
            TestContext.Properties["information"] = "Bu bir ekstra bilgidir";

            Assert.AreEqual(1, 1);
        }


        [TestCleanup]
        public void TestCleanup()
        {
            TestContext.WriteLine("--TestCleanup--\n");
            TestContext.WriteLine("Test Adı: {0}", TestContext.TestName);
            TestContext.WriteLine("Test Durumu: {0}", TestContext.CurrentTestOutcome);
            TestContext.WriteLine("Test Sınıfı: {0}", TestContext.FullyQualifiedTestClassName);
            TestContext.WriteLine("Test Bilgi: {0}", TestContext.Properties["information"]);

            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void TestMethod1()
        {
            TestContext.WriteLine("--TestMethod1--\n");
            TestContext.WriteLine("Test Adı: {0}", TestContext.TestName);
            TestContext.WriteLine("Test Durumu: {0}", TestContext.CurrentTestOutcome);
            TestContext.WriteLine("Test Sınıfı: {0}", TestContext.FullyQualifiedTestClassName);
            TestContext.WriteLine("Test Bilgi: {0}", TestContext.Properties["information"]);

            Assert.AreEqual(1, 1);
        }
    }
}
