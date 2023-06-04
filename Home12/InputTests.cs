using Home12.Core;
using OpenQA.Selenium;

namespace Home12
{
    internal class InputTests : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Browser.Instance.Driver.FindElement(By.LinkText("Inputs")).Click();

        }

        [Test]
        [Description("Test from lesson")]
        public void EnterNumbers()
        {
            var input = Browser.Instance.Driver.FindElement(By.TagName("input"));

            input.SendKeys("100");
            input.Clear();

            input.SendKeys("48");
            input.SendKeys(Keys.ArrowUp);
            input.SendKeys(Keys.ArrowUp);

            input.SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.Enter);

            var text = input.GetAttribute("value");
        }

        [Test]
        [Description("Homework. Task 3-d.")]
        public void LettersAndArrows()
        {
            var input = Browser.Instance.Driver.FindElement(By.TagName("input"));

            input.SendKeys("a" + Keys.ArrowUp);
            Assert.AreEqual("1", input.GetAttribute("value"));

            input.Clear();

            input.SendKeys("b" + Keys.ArrowDown);
            Assert.AreEqual("-1", input.GetAttribute("value"));
        }
    }
}
