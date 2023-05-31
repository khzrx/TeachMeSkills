namespace SauceDemo.Test
{
    internal class SwagLabBaseTest : BaseTest
    {
        public void Setup()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }
    }
}
