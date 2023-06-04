using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

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

        public string GetAllertText()
        {
            return driver.SwitchTo().Alert().Text;
        }

        public void SwitchToFrame(string id)
        {
            driver.SwitchTo().Frame(id);
        }

        public void SwitchToDefault()
        {
            driver.SwitchTo().DefaultContent();
        }

        public void ContextClickToElement(IWebElement element)
        {
            new Actions(driver)
                .MoveToElement(element)
                .ContextClick()
                .Build()
                .Perform();
        }

        public object ExecuteScript(string script, object argument = null)
        {
            try
            {
                return ((IJavaScriptExecutor)driver).ExecuteScript(script, argument);
            }
            catch(Exception) 
            { 
                return null; 
            }
        }
    }
}
