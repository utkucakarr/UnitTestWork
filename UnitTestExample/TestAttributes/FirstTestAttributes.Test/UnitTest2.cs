using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace FirstTestAttributes.Test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod, Description("Bu bir karekök testi yapan metottur")] // Açıklama
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod, Ignore] // Methodu Pass geçer
        public void TestMethod2()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod, Timeout(1000)] // 1 saniyenin üzerine çıkarsa timeout olsun ve test başarısız olsun 
        public void TestMethod3()
        {
            Thread.Sleep(1500);
            Assert.AreEqual(1, 1);
        }

        [TestMethod, Timeout(TestTimeout.Infinite)] // Sonsuz süre, 
        public void TestMethod4()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
