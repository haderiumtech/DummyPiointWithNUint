using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using NUnitLite;

namespace AutomationPOM
{
    [TestFixture]
    class Program
    {
       
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            string userProfileDir = @"C:\Users\Ali\source\repos";

            // This line of code can store cache so it could run faster in the second time
            ChromeOptions options = new ChromeOptions();
            options.AddArgument($"--user-data-dir={userProfileDir}");

            //Ignore SSL errors
            options.AddArgument("--ignore-certificate-errors");
            options.AddArgument("--ignore-ssl-errors");
            driver = new ChromeDriver(options);

            driver.Navigate().GoToUrl("http://www.dummypoint.com");
            //driver.Navigate().GoToUrl("http://www.dummypoint.com/auth-login.html");
        }

        //[Test]
        //public void SuccessfulLogin()
        //{
        //    GenericFunctionClass GenericMethod = new GenericFunctionClass(driver);
        //    GenericMethod.PerformLogin("ali@yopmail.com", "ali123");
        //}
        [Test,Order(1)]
        public void verifyHeaderText()
        {
          
            GenericFunctionClass GenericMethod = new GenericFunctionClass(driver);
            GenericMethod.websiteHeaderTextAssertion("DUMMYPOINT");
        }
        [Test,Order(2)]
        public void openSeleniumTempletePage()
        {
            WebElements element = new WebElements(driver);
            element.sidebarValue_SeleniumTemplate.Click();
            element.seleniumTemplate_Locaters.Click();
            GenericFunctionClass GenericMethod = new GenericFunctionClass(driver);
            GenericMethod.locaterPageAssertion("Selenium Template");
            Thread.Sleep(5000);

        }

        [TearDown]
        public void Cleanup()
        {
            // Close the browser
            driver.Quit();
        }
    }
}
