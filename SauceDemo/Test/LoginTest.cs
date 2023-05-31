using SauceDemo.PageObject;

namespace SauceDemo.Test
{
    internal class LoginTest : SwagLabBaseTest
    {
        [Test]
        public void Login_StandartUser()
        {
            var inventoryPage = new LoginPage(driver)
                .OpenPage()
                .LoginAsStandartUser();
        }

        [Test]
        public void Login_EmptyUser()
        {
            var user = new UserModel()
            {
                Name = "",
                Password = "",
            };

            var page = new LoginPage(driver);

            page.OpenPage().TryToLogin(user);

            Assert.IsTrue(page.VerifyErrorMessage());
        }
    }
}
