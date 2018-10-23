using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace giving_tests
{
    public sealed class MyWebDriver
    {
       private MyWebDriver()
        {

        }

        private static readonly object padlock = new object();
        private static MyWebDriver instance = null;

        public static MyWebDriver Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new MyWebDriver();
                    }

                    return instance;
                }
            }
        }

        public IWebDriver Driver = new ChromeDriver();
    }
}
