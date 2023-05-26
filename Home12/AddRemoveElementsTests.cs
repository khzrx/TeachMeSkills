using OpenQA.Selenium;

namespace Home12
{
    internal class AddRemoveElementsTests : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            driver.FindElement(By.LinkText("Add/Remove Elements")).Click();
        }

        [Test]
        [Description("Test from lesson")]
        public void AddRemoveButton()
        {
            var expectedUrl = "http://the-internet.herokuapp.com/add_remove_elements/";

            Assert.That(driver.Url, Is.EqualTo(expectedUrl));

            driver.FindElement(By.TagName("button")).Click();
            var addedButton = driver.FindElement(By.ClassName("added-manually"));
            Assert.That(addedButton, Is.Not.Null);

            addedButton.Click();
            Assert.That(driver.FindElements(By.ClassName("added-manually")), Is.Empty);
        }

        [Test]
        [Description("Homework. Task 3-a.")]
        public void AddTwoButtonsRemoveOne()
        {
            driver.FindElement(By.XPath("//button[text()='Add Element']")).Click();
            driver.FindElement(By.XPath("//button[text()='Add Element']")).Click();
            driver.FindElement(By.XPath("//button[text()='Delete']")).Click();

            Assert.That(1, Is.EqualTo(driver.FindElements(By.ClassName("added-manually")).Count));
        }
    }
}
