using Home12.Core;
using OpenQA.Selenium;

namespace Home12
{
    internal class CheckBoxTests : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Browser.Instance.Driver.FindElement(By.LinkText("Checkboxes")).Click();
        }

        [Test]
        [Description("Test from lesson")]
        public void CheckBoxes()
        {
            List<IWebElement> checkBoxes = Browser.Instance.Driver.FindElements(By.TagName("input")).ToList();
            Assert.IsNotEmpty(checkBoxes);

            var checkBoxOne = checkBoxes[0];
            var checkBoxSecond = checkBoxes[1];

            SetCheckBoxState(checkBoxOne, false);
            SetCheckBoxState(checkBoxOne, true);
            SetCheckBoxState(checkBoxOne, true);
            SetCheckBoxState(checkBoxOne, false);

            checkBoxOne.Click();
            var selected = checkBoxOne.Selected;
            var selectedByAttribute = checkBoxOne.GetAttribute("checked");

            selected = checkBoxSecond.Selected;
            selectedByAttribute = checkBoxSecond.GetAttribute("checked");
        }

        [Test]
        [Description("Homework. Task 3-b.")]
        public void CheckAndUncheck()
        {
            List<IWebElement> checkBoxes = Browser.Instance.Driver.FindElements(By.CssSelector("[type=checkbox]")).ToList();
            Assert.IsNotEmpty(checkBoxes);

            var checkBoxOne = checkBoxes[0];
            var checkBoxSecond = checkBoxes[1];

            Assert.IsFalse(checkBoxOne.Selected);
            SetCheckBoxState(checkBoxOne, true);
            Assert.IsTrue(checkBoxOne.Selected);

            Assert.IsTrue(checkBoxSecond.Selected);
            SetCheckBoxState(checkBoxSecond, false);
            Assert.IsFalse(checkBoxSecond.Selected);
        }

        public void SetCheckBoxState(IWebElement element, bool flag)
        {
            var selected = element.Selected;
            bool.TryParse(element.GetAttribute("checked"), out bool selectedByAttribute);

            if ((selected || selectedByAttribute) != flag)
            {
                element.Click();
            }
        }
    }
}
