using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessLayer.Test
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Users.xml",
            "User", DataAccessMethod.Sequential)]
        [TestMethod]
        public void DataTest()
        {
            var manager = new UserManager();

            var name = TestContext.DataRow["name"].ToString();
            var phone = TestContext.DataRow["phone"].ToString();
            var email = TestContext.DataRow["email"].ToString();

            var result = manager.AddUser(name, phone, email);

            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataSource("MyDataSource")]
        public void DataTest2()
        {
            var processManager = new ProcessManager();

            int x = Convert.ToInt32(TestContext.DataRow["x"]);
            int y = Convert.ToInt32(TestContext.DataRow["y"]);
            int expected = Convert.ToInt32(TestContext.DataRow["expected"]);

            int actual = processManager.Sum(x, y);

            Assert.AreEqual(actual, expected);
        }
    }
}
