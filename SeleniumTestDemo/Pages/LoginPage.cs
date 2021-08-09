using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestDemo.Pages
{
    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }
        public IWebDriver Driver { get;}

        
        public IWebElement txtUsername => Driver.FindElement(By.Name("UserName"));
        public IWebElement txtPassword => Driver.FindElement(By.Name("Password"));
        public IWebElement btnLogin => Driver.FindElement(By.XPath("//input[@value = 'Log in']"));

        public void Login(String userName, String password)
        {
            txtUsername.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.Submit();
        }
            
    }
}
