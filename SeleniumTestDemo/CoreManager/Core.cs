using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTestDemo
{
    public class Core
    {
        public static IWebDriver driver = null;

        public static IWebDriver Initialize()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
               
                driver.Manage().Window.Maximize();
                
                driver.Navigate().GoToUrl(Constants.Url);
            }

            return driver;

        }  
        
        public static void Quit()
        {
            Console.WriteLine("quitting of Webdriver");

            driver.Quit();

            driver = null;
        }
        public static void Close()
        {
            Console.WriteLine("closing browser");
         
            driver.Close();
          
            driver = null;
        }

    }
    
}
