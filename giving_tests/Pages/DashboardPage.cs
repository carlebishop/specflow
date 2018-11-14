using OpenQA.Selenium;

namespace giving_tests
{
    public class DashboardPage
    {

        private readonly IWebDriver _driver;
        public DashboardPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public string UserName => _driver.FindElement(By.Id("user-name")).Text;   // C#6 getter

 
    }
}
