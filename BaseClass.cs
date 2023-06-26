using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;

namespace AutomationPOM
{
    class BaseClass
    {
        protected IWebDriver driver;
        protected Actions actions;

        public BaseClass(IWebDriver driver)
        {
            this.driver = driver;
           // GetScreenshot();
            // actions = new Actions(driver);
        }

        public string GetScreenshot()
        {
            if (driver is ITakesScreenshot takesScreenshotDriver)
            {
                var file = takesScreenshotDriver.GetScreenshot();
                var img = file.AsBase64EncodedString;

                return img;
            }
            else
            {
                return null;
            }
        }

    }
}
