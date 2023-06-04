using Home12.Core;
using OpenQA.Selenium;

namespace Home12
{
    internal class DynamicControlsTests : BaseTest
    {
        [Test]
        public void DynamicControlsTest()
        {
            By checkBoxLocator = By.Id("checkbox");
            By textLocator = By.Id("message");
            By inputLocator = By.TagName("input");
            By enableButtonLocator = By.XPath("//button[@onclick='swapInput()']");
            string itsGoneText = "It's gone!";
            string itsEnabledText = "It's enabled!";


            Browser.Instance.NavigateToUrl("http://the-internet.herokuapp.com/dynamic_controls");

            Browser.Instance.Driver.FindElement(checkBoxLocator);
            Browser.Instance.Driver.FindElement(By.TagName("button")).Click();
            WaitHelper.WaitElementWithTitle(Browser.Instance.Driver, textLocator, itsGoneText, 15);
            Assert.IsEmpty(Browser.Instance.Driver.FindElements(checkBoxLocator));

            Assert.IsFalse(Browser.Instance.Driver.FindElement(inputLocator).Enabled);
            Browser.Instance.Driver.FindElement(enableButtonLocator).Click();
            WaitHelper.WaitElementWithTitle(Browser.Instance.Driver, textLocator, itsEnabledText, 15);
            Assert.IsTrue(Browser.Instance.Driver.FindElement(inputLocator).Enabled);
        }
    }
}
