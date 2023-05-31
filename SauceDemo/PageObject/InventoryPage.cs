using OpenQA.Selenium;

namespace SauceDemo.PageObject
{
    internal class InventoryPage : BasePage
    {
        private By ShoppingCartLink = By.ClassName("shopping_cart_link");
        private By BackpackAddButton = By.Id("add-to-cart-sauce-labs-backpack");
        private By BackpackRemoveButton = By.Id("remove-sauce-labs-backpack");
        private By ShoppingCartBadge = By.ClassName("shopping_cart_badge");
        private By BackpackLink = By.Id("item_4_title_link");



        public LeftMenu LeftMenu;
        public const string url = "https://www.saucedemo.com/inventory.html";

        public InventoryPage(WebDriver webDriver) : base(webDriver)
        {
            LeftMenu = new LeftMenu(webDriver);
            WaitHelper.WaitElement(driver, ShoppingCartLink);
        }

        public override InventoryPage OpenPage()
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }

        public InventoryPage AddBackpack()
        {
            driver.FindElement(BackpackAddButton).Click();
            return this;
        }

        public InventoryPage RemoveBackpack()
        {
            driver.FindElement(BackpackRemoveButton).Click();
            return this;
        }

        public bool ShoppingCartBadgeDisplayed()
        {
            var elem = driver.FindElements(ShoppingCartBadge);
            return elem.Count() > 0;
        }

        public string ShoppingCartBadgeCount()
        {
            return driver.FindElement(ShoppingCartBadge).Text;
        }

        public string GetBackpackName()
        {
            return driver.FindElement(BackpackLink).Text;
        }

        public CartPage GoToCartPage()
        {
            driver.FindElement(ShoppingCartLink).Click();
            return new CartPage(driver);
        }

    }
}
