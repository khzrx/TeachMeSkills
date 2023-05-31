using SauceDemo.PageObject;

namespace SauceDemo.Test
{
    internal class InventoryTest : SwagLabBaseTest
    {
        [Test]
        public void Inventory_AddBackpack_StandartUser()
        {
            var inventoryPage = new LoginPage(driver)
                .OpenPage()
                .LoginAsStandartUser()
                .AddBackpack();

            Assert.IsTrue(inventoryPage.ShoppingCartBadgeDisplayed());
            Assert.AreEqual("1", inventoryPage.ShoppingCartBadgeCount());
        }

        [Test]
        public void Inventory_RemoveBackpack_StandartUser()
        {
            var inventoryPage = new LoginPage(driver)
                .OpenPage()
                .LoginAsStandartUser()
                .AddBackpack()
                .RemoveBackpack();

            Assert.IsFalse(inventoryPage.ShoppingCartBadgeDisplayed());
        }

    }
}
