using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTestDemo.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestDemo.Tests
{
    public class LoginTest
    {

        [SetUp]
        public void Setup()
        {
            CoreTest.Initialize();
        }

       [Test]
        public void PageLogIn()
        {
            HomePage homePage = new HomePage(CoreTest.driver);
            homePage.ClickLogin();

            LoginPage logpage = new LoginPage(CoreTest.driver);
            logpage.Login("admin", "password");

            Assert.That(homePage.IsEmployeeDetailsExist, Is.True);
   
           
        }

    }
  
}
    