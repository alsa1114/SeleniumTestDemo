using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTestDemo.Pages;


namespace SeleniumTestDemo.Tests
{
    public class EmployeeTest
    {
        IWebDriver webDriver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
            webDriver.Manage().Window.Maximize();
        }
        [Test]
        public void EmplList()
        {
            EmployeePage page = new EmployeePage(webDriver);
          //  HomePage homePage = new HomePage(webDriver);
          //  Assert.That(homePage.IsEmployeeDetailsExist, Is.True);
            page.CLickEmpList();
            page.ClickSearchInput();
            page.SendName();
            page.SearchSubmit();



        }
        /*[TearDown]
        public void Close()
        {
            webDriver.Close();
        }

    }*/

    }
}
