using OpenQA.Selenium;

namespace SauceDemo.PageObject
{
    internal class CheckoutPage : BasePage
    {
        private By FirstNameInput = By.XPath("//*[@data-test='firstName']");
        private By LastNameInput = By.XPath("//*[@data-test='lastName']");
        private By PostalCodeInput = By.XPath("//*[@data-test='postalCode']");
        private By ContinueButton = By.XPath("//*[@data-test='continue']");
        private By ErrorMessage = By.XPath("//*[@data-test='error']");
        private By FinishButton = By.XPath("//*[@data-test='finish']");
        private By ThankYouText = By.CssSelector(".complete-header");



        public CheckoutPage(WebDriver webDriver) : base(webDriver)
        {
        }

        public override BasePage OpenPage()
        {
            throw new NotImplementedException();
        }

        public CheckoutPage FillUserData(UserModel user)
        {
            driver.FindElement(FirstNameInput).SendKeys(user.FirstName);
            driver.FindElement(LastNameInput).SendKeys(user.LastName);
            driver.FindElement(PostalCodeInput).SendKeys(user.PostalCode);
            driver.FindElement(ContinueButton).Click();
            return this;
        }

        public bool VerifyErrorMessage()
        {
            return driver.FindElement(ErrorMessage).Displayed;
        }

        public CheckoutPage FinishCheckout()
        {
            driver.FindElement(FinishButton).Click();
            return this;
        }

        public string GetThankYouText()
        {
            return driver.FindElement(ThankYouText).Text;
        }

        public string GetErrorText()
        {
            return driver.FindElement(ErrorMessage).Text;
        }
    }
}
