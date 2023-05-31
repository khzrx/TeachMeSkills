using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SauceDemo
{
    public class BaseTest
    {
        protected WebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}