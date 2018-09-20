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
        //private readonly IWebDriver driver = new ChromeDriver("C:\\Source\\giving_tests\\giving_tests\\bin\\Debug");

        //public GivingPage(IWebDriver driver)
        //public TestDriver(IWebDriver driver)
        // public TestDriver()
        // {
        //this.driver = driver;

        //}

        private static TestDriver instance;
        public readonly IWebDriver driver; 

        private TestDriver()
        {
            driver = new ChromeDriver("C:\\Source\\giving_tests\\giving_tests\\bin\\Debug");
        }

        public static TestDriver Instance
        {
            get
            {
                if (instance == null)
                {
                    try
                    {
                        instance = new TestDriver();
                    }
                    catch (Exception e)
                    {
                        return null;
                    }
                }
                return instance;
            }
        }

    }
  
}
