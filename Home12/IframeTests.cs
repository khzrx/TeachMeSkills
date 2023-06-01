using Home12.Core;
using OpenQA.Selenium;

namespace Home12
{
    internal class IframeTests : BaseTest
    {
        [Test]
        public void Iframe()
        {
            Browser.Instance.NavigateToUrl("http://the-internet.herokuapp.com/iframe");
            Browser.Instance.SwitchToFrame("mce_0_ifr");
            var text = Browser.Instance.Driver.FindElement(By.TagName("p")).Text;

            Browser.Instance.SwitchToDefault();

        }
    }
}
