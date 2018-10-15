using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace giving_tests
{
    class CampusGivingPage
    {
        private const string startUrl = "http://apptest.easytithe.elexio.me/app/Giving/gpt/";
        private readonly IWebDriver _driver;
        public CampusGivingPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public static CampusGivingPage NavigateTo(IWebDriver driver, string campus)
        {

            driver.Navigate().GoToUrl(startUrl + campus);
            return new CampusGivingPage(driver);
        }
        
    }
}
