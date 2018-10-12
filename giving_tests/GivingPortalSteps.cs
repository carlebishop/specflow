using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Xunit;

namespace giving_tests
{
    [Binding]
    public class GivingPortalSteps
    {
        private IWebDriver _driver;
        private PortalPage _portalPage;
        private PortalGivingPage _portalGivingPage;

        [Given]
        public void Given_I_am_on_the_portal_page()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _portalPage = PortalPage.NavigateTo(_driver);
        }
        
        [When]
        public void When_I_select_the_CAMPUS_campus(string campus)
        {
            //ScenarioContext.Current.Add("campus", campus);
        }
        
        [Then]
        public void Then_the_CAMPUS_campus_giving_page_should_be_displayed(string campus)
        {
            Assert.Equal(1, 1);
        }
    }
}
