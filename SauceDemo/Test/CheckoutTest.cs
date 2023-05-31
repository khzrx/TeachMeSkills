using SauceDemo.PageObject;

namespace SauceDemo.Test
{
    internal class CheckoutTest : BaseTest
    {
        [Test]
        public void Checkout_BuyBackpack_StandartUser()
        {
            var user = new UserModel()
            {
                FirstName = "John",
                LastName = "Doe",
                PostalCode = "ABC123"
            };

            var inventoryPage = new LoginPage(driver)
                .OpenPage()
                .LoginAsStandartUser()
                .AddBackpack()
                .GoToCartPage()
                .GoToCheckoutPage();

            inventoryPage.FillUserData(user);

            var checkoutPage = new CheckoutPage(driver);
            checkoutPage.FinishCheckout();

            Assert.AreEqual("Thank you for your order!", checkoutPage.GetThankYouText());
        }

        [Test]
        public void Checkout_EmptyLoginError_StandartUser()
        {
            var user = new UserModel()
            {
                FirstName = "",
                LastName = "Doe",
                PostalCode = "ABC123"
            };

            var inventoryPage = new LoginPage(driver)
                .OpenPage()
                .LoginAsStandartUser()
                .AddBackpack()
                .GoToCartPage()
                .GoToCheckoutPage();

            inventoryPage.FillUserData(user);

            Assert.AreEqual("Error: First Name is required", inventoryPage.GetErrorText());
        }
    }
}
