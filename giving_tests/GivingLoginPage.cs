using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace giving_tests
{
    public class GivingLoginPage
    {
        private readonly IWebDriver driver = new ChromeDriver("C:\\Source\\giving_tests\\giving_tests\\bin\\Debug");
        // Global variables from the Katalon demo - should convert external data and pass in as params
        private readonly string startUrl = "https://test.easytithe.elexio.me/cp3o/Account/Login";
        private readonly string userName = "amandeep.singh@ministrybrands.com";
        private readonly string userPassWord = "Parish10";
        private readonly string transactionFundName = "DefaultFund";  
        private readonly string transactionAmount = "DefaultAmt";
        private readonly string transactionMessage = "DefaultMessage";


        //public GivingPage(IWebDriver driver)
        public GivingLoginPage()
        {
            //this.driver = driver;
            
        }
        
        private IWebElement LoginUserName
        {
            get
            {
                return this.driver.FindElement(By.Id("UserName"));
            }
        }

        private IWebElement LoginPassword
        {
            get
            {
                return this.driver.FindElement(By.Id("Password"));
            }
        }

        private IWebElement LoginButton
        {
            get
            {
                return this.driver.FindElement(By.Id("login"));
            }
        }

        public void NavToPage()
        {
            driver.Navigate().GoToUrl(startUrl);
            driver.Manage().Window.Maximize();

            return;
        }

        public bool LogIn()
        {
            LoginUserName.SendKeys(userName);
            LoginPassword.SendKeys(userPassWord);
            LoginButton.Click();


            return true;
        }
    }


    

}
