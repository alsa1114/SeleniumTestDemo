using OpenQA.Selenium;


namespace SeleniumTestDemo.Pages
{
    public class EmployeePage

    { 

    public EmployeePage(IWebDriver driver)
    {
            Driver = driver;
    }

        private IWebDriver Driver { get; }

        public IWebElement EmployeeList => Driver.FindElement(By.LinkText("Employee List"));
        public IWebElement Search => Driver.FindElement(By.Name("searchTerm"));
        public IWebElement BtnSearch => Driver.FindElement(By.XPath("//input[@value='Search']"));
        

        public void CLickEmpList() => EmployeeList.Click();
       
        public void ClickSearchInput() => Search.Click();

        public void SendName()
        {
            Search.SendKeys("Varuna");
        }
        public void SearchSubmit() => BtnSearch.Submit();
    
    }

}
