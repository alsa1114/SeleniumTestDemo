using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestDemo.Pages
{
    public class HomePage 
    {
        public HomePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }


        public IWebElement LnkLogin => Driver.FindElement(By.LinkText("Login"));
        public IWebElement LnkEmployeeDetails => Driver.FindElement(By.LinkText("Employee Details"));


        public void ClickLogin() => LnkLogin.Click();

        public bool IsEmployeeDetailsExist() => LnkEmployeeDetails.Displayed;

    }
}
