using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestDemo.Pages
{
    class LoginPage
    {
        public LoginPage(IWebDriver driver)

        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        IWebElement txtUsername => Driver.FindElement(By.Name("UserName"));
        IWebElement txtPassword => Driver.FindElement(By.Name("Password"));
        IWebElement btnLogin => Driver.FindElement(By.XPath("//input[@value = 'Log in']"));   
            

        public void Login(String userName, String password)
        {
            txtUsername.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.Submit();
        }
            
    }
}
