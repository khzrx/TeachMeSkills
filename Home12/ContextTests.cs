using Home12.Core;
using OpenQA.Selenium;

namespace Home12
{
    internal class ContextTests
    {
        [Test]
        public void ContextTest()
        {
            string expectedAllertText = "You selected a context menu";

            Browser.Instance.NavigateToUrl("http://the-internet.herokuapp.com/context_menu");
            var element = Browser.Instance.Driver.FindElement(By.Id("hot-spot"));
            Browser.Instance.ContextClickToElement(element);

            Assert.AreEqual(expectedAllertText, Browser.Instance.GetAllertText());

            Browser.Instance.AcceptAllert();
        }
    }
}
