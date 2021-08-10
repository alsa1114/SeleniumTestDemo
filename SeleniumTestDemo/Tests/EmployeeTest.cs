using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTestDemo.Pages;


namespace SeleniumTestDemo.Tests
{
    [TestFixture]
    public class EmployeeTest
    {
      

        [SetUp]
        public void Setup()

        {
            CoreTest.Initialize();

        }

        [Test]
        public void EmplList()
        {
            EmployeePage page = new EmployeePage(CoreTest.driver);

            page.CLickEmpList();
            page.ClickSearchInput();
            page.SendName();
            page.SearchSubmit();

        }
       
         [TearDown]
          public void Close()
          {
              CoreTest.Close();
          }

      }

    }

