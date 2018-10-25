using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Xunit;

namespace giving_tests
{
    [Binding]
    public class GivingPortalSteps
    {
        private IWebDriver _driver;
        private PortalPage _portalPage;
        private CampusGivingPage _campusGivingPage;


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

            // tbd - write a test that actually selects the link on the page rather than using the URL
            _campusGivingPage = CampusGivingPage.NavigateTo(_driver, campus);

        }
        
        [Then]
        public void Then_the_CAMPUS_campus_giving_page_should_be_displayed(string campus)
        {
            Assert.Contains("gpt/" + campus, _driver.Url);
           _driver.Dispose();
        }

        [Given(@"I have input the following users")]
        public void GivenIHaveInputTheFollowingUsers(IEnumerable<NewUser> users)
        {
            // now we have a list of users we can iterate through
            
            // An alternate way would be to leave the weekly typed table and done this instead using Specflow.Assist
            //IEnumerable<dynamic> users = table.CreateDynamicSet();
        }

        [When(@"I choose add")]
        public void WhenIChooseAdd()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the users should be added")]
        public void ThenTheUsersShouldBeAdded()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
