using OpenQA.Selenium;

namespace SauceDemo.PageObject
{
    internal class CartPage : BasePage
    {
        private By CheckoutButton = By.XPath("//*[@data-test='checkout']");
        private By ContinueShoppingButton = By.XPath("//*[@data-test='continue-shopping']");
        private By BackpackLink = By.Id("item_4_title_link");

        public const string url = "https://www.saucedemo.com/cart.html";

        public CartPage(WebDriver webDriver) : base(webDriver)
        {
        }

        public override CartPage OpenPage()
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }

        public string GetBackpackName()
        {
            return driver.FindElement(BackpackLink).Text;
        }

        public CheckoutPage GoToCheckoutPage()
        {
            driver.FindElement(CheckoutButton).Click();
            return new CheckoutPage(driver);
        }
    }
}
