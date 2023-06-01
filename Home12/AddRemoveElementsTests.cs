using Home12.Core;
using OpenQA.Selenium;

namespace Home12
{
    internal class AddRemoveElementsTests : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Browser.Instance.Driver.FindElement(By.LinkText("Add/Remove Elements")).Click();
        }

        [Test]
        [Description("Test from lesson")]
        public void AddRemoveButton()
        {
            var expectedUrl = "http://the-internet.herokuapp.com/add_remove_elements/";

            Assert.That(Browser.Instance.Driver.Url, Is.EqualTo(expectedUrl));

            Browser.Instance.Driver.FindElement(By.TagName("button")).Click();
            var addedButton = Browser.Instance.Driver.FindElement(By.ClassName("added-manually"));
            Assert.That(addedButton, Is.Not.Null);

            addedButton.Click();
            Assert.That(Browser.Instance.Driver.FindElements(By.ClassName("added-manually")), Is.Empty);
        }

        [Test]
        [Description("Homework. Task 3-a.")]
        public void AddTwoButtonsRemoveOne()
        {
            Browser.Instance.Driver.FindElement(By.XPath("//button[text()='Add Element']")).Click();
            Browser.Instance.Driver.FindElement(By.XPath("//button[text()='Add Element']")).Click();
            Browser.Instance.Driver.FindElement(By.XPath("//button[text()='Delete']")).Click();

            Assert.That(1, Is.EqualTo(Browser.Instance.Driver.FindElements(By.ClassName("added-manually")).Count));
        }
    }
}
