using OpenQA.Selenium;
using System;

namespace SeleniumTestDemo.Pages
{
    public class Autorization
    {
        public Autorization(IWebDriver driver)
        {
            Driver = driver;
        }
        public IWebDriver Driver { get;}

        
        public IWebElement TxtUsername => Driver.FindElement(By.Name("UserName"));
        public IWebElement TxtPassword => Driver.FindElement(By.Name("Password"));
        public IWebElement BtnLogin => Driver.FindElement(By.XPath("//input[@value = 'Log in']"));
        public IWebElement LnkLogoff => Driver.FindElement(By.LinkText("Log off"));
        public IWebElement LnkManageUsers => Driver.FindElement(By.LinkText("Manage Users"));


        public void LogIn(String userName, String password)
        {
            TxtUsername.SendKeys(userName);

            TxtPassword.SendKeys(password);
            
            BtnLogin.Submit();
        }

        public void Logout() => LnkLogoff.Click();

        public bool IsManageUsersExist() => LnkManageUsers.Displayed;

    }
}
