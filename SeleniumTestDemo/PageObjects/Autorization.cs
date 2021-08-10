using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestDemo.Pages
{
    public class Autorization
    {
        public Autorization(IWebDriver driver)
        {
            Driver = driver;
        }
        public IWebDriver Driver { get;}

        
        public IWebElement txtUsername => Driver.FindElement(By.Name("UserName"));
        public IWebElement txtPassword => Driver.FindElement(By.Name("Password"));
        public IWebElement btnLogin => Driver.FindElement(By.XPath("//input[@value = 'Log in']"));
        public IWebElement lnkLogoff => Driver.FindElement(By.LinkText("Log off"));
        public IWebElement lnkManageUsers => Driver.FindElement(By.LinkText("Manage Users"));


        public void LogIn(String userName, String password)
        {
            txtUsername.SendKeys(userName);

            txtPassword.SendKeys(password);
            
            btnLogin.Submit();
        }

        public void Logout() => lnkLogoff.Click();

        public bool isManageUsersExist() => lnkManageUsers.Displayed;

    }
}
