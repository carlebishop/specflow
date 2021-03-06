﻿using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace giving_tests.Pages
{
    public class GivingLoginPage
    {
        // Global variables from the Katalon demo - should convert external data and pass in as params
        private const string startUrl = "https://test.easytithe.elexio.me/cp3o/Account/Login";


        private readonly IWebDriver _driver;

        public GivingLoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public static GivingLoginPage NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(startUrl);
            return new GivingLoginPage(driver);
        }

        public string LoginUserName
        {
            set
            {
                _driver.FindElement(By.Id("UserName")).SendKeys(value);
            }
        }

        public string LoginPassword
        {
            set
            {
                _driver.FindElement(By.Id("Password")).SendKeys(value);
            }
        }

        public DashboardPage PressLoginButton()
        {
            _driver.FindElement(By.Id("login")).Click();
            return new DashboardPage(_driver);
        }

        //public string ReturnLink => _driver.FindElement(By.LinkText("Return to Login")).Text;
       //public string ValidationError => _driver.FindElement(By.Name("li")).ToString();

        public bool ValidationErrorPresent()
        {
            // The error will either show up in the timeout as this link, or will show up as username or password provided is incorrect
            try
            {
                if (_driver.FindElement(By.LinkText("Return to Login")) != null)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                
            }


            ReadOnlyCollection<IWebElement> errorList = _driver.FindElements(By.TagName("li"));
            foreach (IWebElement item in errorList)
            {
                if (item.Text == "The username or password provided is incorrect.")
                {
                    return true;
                }
            }

            return false;
        }
    }
}
   


