using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace giving_tests
{
    class PortalPage
    {
        // Global variables from the Katalon demo - should convert external data and pass in as params
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
