using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace AutomationPOM
{
    class GenericFunctionClass : WebElements
    {
        private WebElements Elements;

        public GenericFunctionClass(IWebDriver driver) : base(driver)
        {
            Elements = new WebElements(driver);
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
        public void locaterPageAssertion(string expectedLocaterText)
        {
            try
            {
                string actualTextLocater = Elements.locaterPageAssertion.Text;
                Assert.AreEqual(expectedLocaterText, actualTextLocater, $"The text is not same");
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
            }
            catch (Exception ex)
            {
                // Handle the exception as per your requirement
                Console.WriteLine("Exception occurred while puting text: " + ex.Message);
            }
        }


    }
}
