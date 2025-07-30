using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Asserts.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            const double inputValue = 16;
            const double expected = 4;
            double actualed = Math.Sqrt(inputValue);

            Assert.AreEqual(expected, actualed, "{0} sayısının karekökü {1} olmadılıdır", inputValue, expected);
        }

        [TestMethod]
        public void TestMethod2()
        {
            double expected = 3.1622;
            // Formül: |beklenen-gerçekleşen|<=delta
            // Virgülden sonra 4 basamağın doğru olmasını bekledik
            double delta = 0.0001;

            double actualed = Math.Sqrt(10);
            Assert.AreEqual(expected, actualed, delta);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string expected = "MERHABA";
            string actualed = "merhaba";

            // Küçük büyük harf duyarsız oldu true ile
            Assert.AreEqual(expected, actualed, true);
        }

        [TestMethod]
        public void TestMethod4()
        {
            const double unExpected = 0;
            var actual = Math.Pow(5, 0);

            Assert.AreNotEqual(unExpected, actual);
        }
    }
}
