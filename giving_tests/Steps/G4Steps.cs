using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace giving_tests.Steps
{
    [Binding]
    public class G4Steps
    {
        private IWebDriver _driver;
        private CampusGivingPage _campusGivingPage;

        [Given(@"I am on the (.*) giving page")]
        public void GivenIAmOnTheGivingPage(string campus)
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _campusGivingPage = CampusGivingPage.NavigateTo(_driver, campus); 
        }
        
        [When(@"I select (.*) from the fund drop down")]
        public void WhenISelectFromTheFundDropDown(string fund)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter (.*) into the amount")]
        public void WhenIEnterIntoTheAmount(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I fill out the credit card information with a test card")]
        public void WhenIFillOutTheCreditCardInformationWithATestCard()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press submit")]
        public void WhenIPressSubmit()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see a successful transaction message")]
        public void ThenIShouldSeeASuccessfulTransactionMessage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
