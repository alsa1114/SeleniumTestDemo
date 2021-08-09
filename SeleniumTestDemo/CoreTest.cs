using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTestDemo
{
    public class CoreTest
    {
        public static IWebDriver driver = null;

        public static void Initialize()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
            }

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(Constants.url);


        }
        public static void Quit()
        {
            Console.WriteLine("quitting browser");
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
