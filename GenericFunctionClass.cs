using AventStack.ExtentReports;
using DummyPiointWithNUint;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace AutomationPOM
{
    class GenericFunctionClass : WebElements
    {
        private WebElements Elements;
        private TestCasesReport report;

        public GenericFunctionClass(IWebDriver driver) : base(driver)
        {
            Elements = new WebElements(driver);
            //this.report = report;
        }

        //login function
        public void PerformLogin(string username, string password)
        {
            try
            {
                
                Elements.userName.SendKeys(username);
                Elements.password.SendKeys(password);
                Elements.submit.Click();
            }
            catch (Exception ex)
            {
                // Handle the exception as per your requirement
                Console.WriteLine("Exception occurred while performing login: " + ex.Message);
            }
        }
        public void websiteHeaderTextAssertion(string expectedHeaderText)
        {
            try
            {
                string actualText = Elements.webActualText.Text;
                Assert.AreEqual(expectedHeaderText, actualText, $"The text is not same");
                
            }
            catch (Exception ex)
            {
                // Handle the exception as per your requirement
                Console.WriteLine("Exception occurred while performing assertion: " + ex.Message);
            }
            
        }
        public void LocaterPageAssertion(string expectedLocaterText)
        {
            try
            {
                string actualTextLocater = Elements.locaterPageAssertion.Text;
                Assert.AreEqual(expectedLocaterText, actualTextLocater, $"The text is not same");
                //if (expectedLocaterText == actualTextLocater)
                //{
                //    report.LogTestStep(Status.Pass, "Text match successful");
                //    report.LogScreenshot(@"D:\Ali Hammad Hassan\Automatin project\DummyPiointWithNUint\");
                //}
                //else
                //{
                //    report.LogTestStep(Status.Fail, "Text do not match failed");
                //    report.LogScreenshot(@"D:\Ali Hammad Hassan\Automatin project\DummyPiointWithNUint\");
                //}
            }
            catch (Exception ex)
            {
                // Handle the exception as per your requirement
                Console.WriteLine("Exception occurred while performing assertion: " + ex.Message);
            }
        }
        public void enterText(string InputTextBox)
        {
            try
            {
                Elements.seleniumTemplate_Locaters_UserInputText.SendKeys(InputTextBox);
               // report.LogTestStep(Status.Pass, $"Entered text: {InputTextBox}");
            }
            catch (Exception ex)
            {
                // Handle the exception as per your requirement
              //  report.LogTestStep(Status.Fail, "Exception occurred while putting text: " + ex.Message);

              // Console.WriteLine("Exception occurred while puting text: " + ex.Message);
            }
        }


    }
}
