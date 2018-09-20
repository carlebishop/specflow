using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace giving_tests
{
    public class DashboardPage
    {

        IWebDriver driver = TestDriver.Instance.driver;
        public DashboardPage()
        {
        }

        private IWebElement Organization
        {
            get
            {
                //string x = "id('usertray')/li[@class='dropdown']/a[class='dropdown.toggle']";

                //return this.driver.FindElement(By.XPath(x));
         
                return this.driver.FindElement(By.XPath("//ul[@id='usertray']/li[2]/a/spanVirtualTerminal"));
              
            }
        }

        public bool CheckforOrganizationElement()
        {
            if (Organization == null)
            {
                return false;
            }
            else
            {
                Organization.Click();
                return true;
            }
            
        }
    }
}
