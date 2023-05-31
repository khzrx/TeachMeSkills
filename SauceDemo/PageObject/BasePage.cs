using OpenQA.Selenium;

namespace SauceDemo.PageObject
{
    internal abstract class BasePage
    {
        protected WebDriver driver;

        public BasePage(WebDriver webDriver)
        {
            driver = webDriver;
        }

        public abstract BasePage OpenPage();
    }
}
