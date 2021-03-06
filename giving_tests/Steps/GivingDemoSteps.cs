﻿using giving_tests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Xunit;

namespace giving_tests.Steps
{
    [Binding]
    public class GivingDemoSteps
    {
        private IWebDriver _driver;
        private DashboardPage _dashboardPage;
        private GivingLoginPage _givingLoginPage;

        private const string userName = "amandeep.singh@ministrybrands.com";
        private const string userPassWord = "Parish10";
        private const string transactionFundName = "DefaultFund";
        private const string transactionAmount = "DefaultAmt";
        private const string transactionMessage = "DefaultMessage";

        private GivingCommonDetails _givingCommonDetails;
        /// <summary>
        /// constructor to inject GivingCommonDetails for sharing between steps - Dependency Injection
        /// </summary>
        /// <param name="details"></param>
        public GivingDemoSteps(GivingCommonDetails givingCommonDetails)
        {
            _givingCommonDetails = givingCommonDetails;
        }

        [Given]
        public void Given_I_am_on_the_login_page()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _givingLoginPage = GivingLoginPage.NavigateTo(_driver);

        }
        
        [Given]
        public void Given_I_have_entered_my_login_information()
        {
            _givingLoginPage.LoginUserName = userName;
            _givingLoginPage.LoginPassword = userPassWord;
        }
        
        [When]
        public void When_I_press_login()
        {
            _dashboardPage = _givingLoginPage.PressLoginButton();
        }
        
        [Then]
        public void Then_I_should_be_on_the_dashboard_screen()
        {
            Assert.Equal("Amandeep Singh", _dashboardPage.UserName);
            _driver.Dispose();
        }

        [Given]
        public void Given_I_have_entered_BADLOGIN_for_a_userid(string badlogin)
        {
            _givingLoginPage.LoginUserName = badlogin;
            _givingLoginPage.LoginPassword = userPassWord;

            _givingCommonDetails.SomeDetail = badlogin;  // example:  this would allow us to share this between steps
        }

        [Then]
        public void Then_I_should_get_a_failed_login_message()
        {
            Assert.True(_givingLoginPage.ValidationErrorPresent());
            _driver.Dispose();
        }

        
     }

    
}
