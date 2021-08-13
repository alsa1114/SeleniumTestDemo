using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumTestDemo.Pages;

namespace SeleniumTestDemo.Tests
{
    [Parallelizable(ParallelScope.Children)]
   /* [TestFixture(typeof(FirefoxDriver))]
    [TestFixture(typeof(ChromeDriver))]*/

    public class EmployeeTest:Core
    {

        [SetUp]
        public void Setup()

        {
            Core.Initialize();

        }

        [Test]
        public void EmplList()
        {
            EmployeePage page = new EmployeePage(Core.driver);

            page.CLickEmpList();

            page.ClickSearchInput();

            page.SendName();

            page.SearchSubmit();

        }
      
      }

    }

