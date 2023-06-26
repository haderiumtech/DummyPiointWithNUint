using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using NUnitLite;
using DummyPiointWithNUint;
using AventStack.ExtentReports;

namespace AutomationPOM
{
    [TestFixture]
    class Program
    {
       
        private IWebDriver driver;
        private TestCasesReport report;
        protected BaseClass BaseClass { get; private set;}

        [SetUp]
        public void Setup()
        {
            TestCasesReport.CreateTest(TestContext.CurrentContext.Test.MethodName);
            string userProfileDir = @"C:\Users\Ali\source\repos";

            // This line of code can store cache so it could run faster in the second time
            ChromeOptions options = new ChromeOptions();
            options.AddArgument($"--user-data-dir={userProfileDir}");

            //for test reports
            

            //Ignore SSL errors
            options.AddArgument("--ignore-certificate-errors");
            options.AddArgument("--ignore-ssl-errors");
            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("http://www.dummypoint.com");
            //driver.Navigate().GoToUrl("http://www.dummypoint.com/auth-login.html");

            BaseClass = new BaseClass(driver);

        }

        //[Test]
        //public void SuccessfulLogin()
        //{
        //    GenericFunctionClass GenericMethod = new GenericFunctionClass(driver);
        //    GenericMethod.PerformLogin("ali@yopmail.com", "ali123");
        //}
        [Test, Order(1)]
        public void verifyHeaderText()
        {
            GenericFunctionClass GenericMethod = new GenericFunctionClass(driver);
            GenericMethod.websiteHeaderTextAssertion("DUMMYPOINT");
            TestCasesReport.LogInfo("start testing");
        }

        [Test, Order(2)]
        public void openSeleniumTempletePage()
        {
            TestCasesReport.LogInfo("start testing");
            WebElements element = new WebElements(driver);
            element.sidebarValue_SeleniumTemplate.Click();
            element.seleniumTemplate_Locaters.Click();
            GenericFunctionClass GenericMethod = new GenericFunctionClass(driver);
            GenericMethod.LocaterPageAssertion("Selenium Template");
            Thread.Sleep(5000);
        }

        [Test, Order(3)]
        public void textBoxLocatorsPage()
        {
            TestCasesReport.LogInfo("start testing");
            Thread.Sleep(3000);
            GenericFunctionClass GenericMethod = new GenericFunctionClass(driver);
            //report.CreateTest("text Box on Locators Page");
            GenericMethod.enterText("DUMMYPOINT");
            Thread.Sleep(5000);

        }

        [TearDown]
        public void Cleanup()
        {
            // Close the browser
            
            EndTest();
            TestCasesReport.EndReport();
            driver.Quit();
            /*driver.quit() must be on end other wise getting disp0se error on getscreenshot funtion in
             *Baseclass */


        }

        private void EndTest()
        {
            var testStatus = TestContext.CurrentContext.Result.Outcome.Status;
            var message = TestContext.CurrentContext.Result.Message;

            switch(testStatus)
            {
                case TestStatus.Failed:
                    TestCasesReport.LogFail($"test has failed {message}");
                    break;
                case TestStatus.Skipped:
                    TestCasesReport.LogInfo($"Test skipped{message}");
                    break;
                default:
                    break;
            }
            TestCasesReport.LogScreenShot("ending test", BaseClass.GetScreenshot());

        } 
    }
}
