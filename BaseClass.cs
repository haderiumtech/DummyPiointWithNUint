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
            actions = new Actions(driver);
        }

    }
}
