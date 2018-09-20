using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace giving_tests
{
    public class TestDriver
    {
       private readonly IWebDriver driver = new ChromeDriver("C:\\Source\\giving_tests\\giving_tests\\bin\\Debug");

        //public GivingPage(IWebDriver driver)
        //public TestDriver(IWebDriver driver)
        public TestDriver()
        {
            //this.driver = driver;

        }

       
    }
}
