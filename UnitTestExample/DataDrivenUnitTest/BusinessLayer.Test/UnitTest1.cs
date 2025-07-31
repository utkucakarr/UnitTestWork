using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
