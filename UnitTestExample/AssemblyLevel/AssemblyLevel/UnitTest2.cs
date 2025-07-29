using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace AssemblyLevel
{
    [TestClass]
    public class UnitTest2
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            Debug.WriteLine("Running UnitTest2 ClassInitialize");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Debug.WriteLine("Running UnitTest2 Classcleanup");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            Debug.WriteLine("Running UnitTest2 TestInitialize");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Debug.WriteLine("Running UnitTest2 TestClenup");
        }

        [TestMethod]
        public void TestMethod3()
        {
            Debug.WriteLine("Running TestMethod3");
        }

        [TestMethod]
        public void TestMethod4()
        {
            Debug.WriteLine("Running TestMethod4");
        }
    }
}