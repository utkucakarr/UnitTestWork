using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AreSameWork.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var numbers = new byte[] { 1, 2, 3, };
            var otherNumbers = numbers;
            numbers[0] = 4;
            otherNumbers[1] = 5;

            // AreSame referanslara bakar
            Assert.AreSame(numbers, otherNumbers);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int a = 10;
            int b = a;

            Assert.AreEqual(a, b, "AreEqual fail oldu");
            Assert.AreSame(a, b, "AreSame fail oldu");
            Assert.AreNotSame(a, b, "AreSame fail oldu");
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(1, 1);
            // Hata mesajı fırlatır.
            Assert.Inconclusive("Bu test yeterli değildir");
        }

        [TestMethod]
        public void TestMethod4()
        {
            var number = 5m;

            // type doğrulama yapar.
            Assert.IsInstanceOfType(number, typeof(decimal));
            Assert.IsNotInstanceOfType(number, typeof(int));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsTrue(10 % 2 == 0);
            Assert.IsFalse(10 % 2 == 1);
        }
    }
}
