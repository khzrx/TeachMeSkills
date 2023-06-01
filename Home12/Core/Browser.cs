using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Home12.Core
{
    internal class Browser
    {
        private static Browser instance = null;
        private IWebDriver driver;
        public IWebDriver Driver { get { return driver; } }

        public static Browser Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Browser();
                }
                return instance;
            }
        }

        private Browser()
        {
            bool isHeadless = false;

            if (isHeadless)
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--headless");

                driver = new ChromeDriver(options);
            }
            else
            {
                driver = new ChromeDriver();
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
        }

        public void CloseBrowser()
        {
            driver?.Dispose();
            instance = null;
        }

        public void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void AcceptAllert()
        {
            driver.SwitchTo().Alert().Accept();
        }

        public void DismissAllert()
        {
            driver.SwitchTo().Alert().Dismiss();
        }
    }
}
