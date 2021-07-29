using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace SeleniumTestDemo
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

                }

        [Test]
        public void Test1()
        {


            IWebDriver webDriver = new ChromeDriver(@"C:\driver\chromedriver_win32");
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
            webDriver.Manage().Window.Maximize();


            IWebElement lnkLogin = webDriver.FindElement(By.LinkText("Login"));
            lnkLogin.Click();

            var txtUsername = webDriver.FindElement(By.Name("UserName"));

            Assert.That(txtUsername.Displayed, Is.True);

            txtUsername.SendKeys("admin");

            webDriver.FindElement(By.Name("Password")).SendKeys("password");

            webDriver.FindElement(By.XPath("//input[@value = 'Log in']")).Submit();

            var lnkEmployeeDetails = webDriver.FindElement(By.LinkText("Employee Details"));

            Assert.That(lnkEmployeeDetails.Displayed, Is.True);
        }
    }
}