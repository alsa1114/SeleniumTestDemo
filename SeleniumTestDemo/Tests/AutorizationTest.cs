using NUnit.Framework;
using SeleniumTestDemo.Pages;

namespace SeleniumTestDemo.Tests
{   
    [TestFixture]   
    public class AutorizationTest
    {

        [SetUp]
        public void Setup()
        {
            CoreTest.Initialize();
        }

       [Test]
        public void PageLogin()
        {
            
            HomePage homePage = new HomePage(CoreTest.driver);
            homePage.ClickLogin();

            Autorization logpage = new Autorization(CoreTest.driver);
            logpage.LogIn("admin", "password");

            Assert.That(homePage.IsEmployeeDetailsExist, Is.True);

        }

        [Test]
        public void PageLogout()
        {
            Autorization auto = new Autorization(CoreTest.driver);

            Assert.That(auto.isManageUsersExist, Is.True);

            auto.Logout();

        }

        /*[TearDown]
        public void Close()
        {
            CoreTest.Close();
        }*/

    }
  
}
    