using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System.Net.NetworkInformation;
using SeleniumExtras.WaitHelpers;


namespace AutomationPOM
{
    class WebElements : BaseClass
    {
        private readonly WebDriverWait wait;

        public WebElements(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);// wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)); // Initialize WebDriverWait
        }

        [FindsBy(How = How.Id, Using = "email")] public IWebElement userName { get; set; }
        [FindsBy(How = How.Id, Using = "password")] public IWebElement password { get; set; }
        [FindsBy(How = How.XPath, Using = "*//button[@type='submit']")] public IWebElement submit { get; set; }
        

        //***********sidebar xpaths**********8
        [FindsBy(How = How.XPath,Using = "//span[contains(text(),'Selenium Template')]")] public IWebElement sidebarValue_SeleniumTemplate { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Locators') and contains(@class, 'nav-link')]")] public IWebElement seleniumTemplate_Locaters{ get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='user_input']")] public IWebElement seleniumTemplate_Locaters_UserInputText { get; set; }
        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'DummyPoint')])[2]")] public IWebElement webActualText{ get; set;}
        [FindsBy(How = How.XPath, Using = "//*[@id=\"app\"]/div/div[3]/section/div[1]/h1")] public IWebElement locaterPageAssertion { get; set; }

    }
}
