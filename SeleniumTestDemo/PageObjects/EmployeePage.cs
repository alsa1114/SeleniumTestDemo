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

        public IWebElement employeeList => Driver.FindElement(By.LinkText("Employee List"));
        public IWebElement search => Driver.FindElement(By.Name("searchTerm"));
        public IWebElement btnSearch => Driver.FindElement(By.XPath("//input[@value='Search']"));
        

        public void CLickEmpList() => employeeList.Click();
       
        public void ClickSearchInput() => search.Click();

        public void SendName()
        {
            search.SendKeys("Varuna");
        }
        public void SearchSubmit() => btnSearch.Submit();
    
    }

}
