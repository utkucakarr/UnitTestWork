using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace AssemblyLevel
{
    [TestClass]
    public class UnitTest1
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext)
        {
            Debug.WriteLine("Running Assembly Initialize");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Debug.WriteLine("Running Assembly Cleanup");
        }

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            Debug.WriteLine("Running Class Initialize");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Debug.WriteLine("Running Class Cleanup");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            Debug.WriteLine("Running Test Initialize");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Debug.WriteLine("Running Test Cleanup");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Debug.WriteLine("Running TestMethod1");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Debug.WriteLine("Running TestMethod2");
        }

    }
}
