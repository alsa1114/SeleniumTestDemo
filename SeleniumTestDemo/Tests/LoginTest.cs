using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTestDemo.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestDemo.Tests
{
    class LoginTest
    {

        IWebDriver webDriver = new ChromeDriver(@"C:\driver\chromedriver_win32");

        [SetUp]
        public void Setup()
        {
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
            webDriver.Manage().Window.Maximize();
        }

        [Test]
        public void Login()
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();

            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.Login("admin", "password");
            Assert.That(homePage.IsEmployeeDetailsExist, Is.True);


        }
        [TearDown]
        public void Close()
        {
            webDriver.Close();
        }
    }
}