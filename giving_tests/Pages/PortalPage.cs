using OpenQA.Selenium;

namespace giving_tests.Pages
{
    class PortalPage
    {
        
        private const string startUrl = "http://apptest.easytithe.elexio.me/app/Giving/gpt/";


        private readonly IWebDriver _driver;

        public PortalPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public static PortalPage NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(startUrl);
            return new PortalPage(driver);
        }
    }
}
