using SauceDemo.PageObject;

namespace SauceDemo.Test
{
    internal class CartTest : SwagLabBaseTest
    {
        [Test]
        public void Cart_CheckAddedItemTitle_StandartUser()
        {
            var inventoryPage = new LoginPage(driver)
                .OpenPage()
                .LoginAsStandartUser()
                .AddBackpack()
                .GoToCartPage();

            Assert.AreEqual("Sauce Labs Backpack", inventoryPage.GetBackpackName());
        }
    }
}
