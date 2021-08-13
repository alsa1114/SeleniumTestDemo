using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

using SeleniumTestDemo.Pages;


namespace SeleniumTestDemo.Tests
{
    [Parallelizable(ParallelScope.Fixtures)]
   /* [TestFixture(typeof(FirefoxDriver))]
    [TestFixture(typeof(ChromeDriver))]*/
    public class AutorizationTest
    {
    
       [SetUp]
        public void Setup()
        {
            Core.Initialize();
        }


      // WebDriverWait wait = new WebDriverWait(Core.driver, System.TimeSpan.FromSeconds(10));

        [Test]
        public void PageLogin()
        {
            
            HomePage homePage = new HomePage(Core.driver);
            
            homePage.ClickLogin();

            Autorization logpage = new Autorization(Core.driver);
            logpage.LogIn("admin", "password");

            Assert.That(homePage.IsEmployeeDetailsExist, Is.True);

        }

        [Test]
        public void PageLogout()
        {
            Autorization auto = new Autorization(Core.driver);

            Assert.That(auto.IsManageUsersExist, Is.True);

            auto.Logout();

        }

    }
  
}
    