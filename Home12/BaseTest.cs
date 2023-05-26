using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Home12
{
    public class BaseTest
    {
        protected WebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}