using OpenQA.Selenium;

namespace SauceDemo
{
    internal class Locators
    {
        // Not done yet.

        private By UserNameInput = By.Id("user-name");
        private By RemoveBackpackButton = By.Name("remove-sauce-labs-backpack");
        private By ShoppingCartLink = By.ClassName("shopping_cart_link");
        private By FilterSelect = By.TagName("select");
        private By BikeLightLink = By.LinkText("Sauce Labs Bike Light");
        private By JacketLink = By.PartialLinkText("Jacket");
        private By PasswordInput = By.XPath("//*[@data-test='password']");
        private By OnesieLink = By.XPath("//div[text()='Sauce Labs Onesie']");
        private By TShirtLink = By.XPath("//div[contains(@id,'item_1')]");
        private By AmericanApparelText = By.XPath("//div[contains(text(),'American Apparel']");
        private By OnesieLinkByAncestor = By.XPath("//*[contains(text(),'Rib snap']//ancestor::a");

    }
}
