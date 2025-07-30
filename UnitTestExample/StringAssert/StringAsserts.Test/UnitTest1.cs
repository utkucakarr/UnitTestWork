using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace StringAsserts.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StringContainsTest()
        {
            StringAssert.Contains("Test dünyasından merhaba", "yas");
        }

        [TestMethod]
        public void StringMatchesTest()
        {
            StringAssert.Matches("Test dünyasından merhaba", new Regex(@"[a-zA-z]"));
            StringAssert.Matches("Test dünyasından merhaba", new Regex(@"[0-9]"));
        }

        [TestMethod]
        public void StartsWithTest()
        {
            StringAssert.StartsWith("Test dünyasından merhaba", "Test");
        }

        [TestMethod]
        public void EndsWithTest()
        {
            StringAssert.EndsWith("Test dünyasından merhaba", "merhaba");
        }
    }
}