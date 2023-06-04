using Home12.Core;
using OpenQA.Selenium;

namespace Home12
{
    internal class AlertTests : BaseTest
    {
        [Test]
        public void AcceptAlert()
        {
            Browser.Instance.NavigateToUrl("http://the-internet.herokuapp.com/javascript_alerts");
            Browser.Instance.Driver.FindElement(By.XPath("(//button)[1]")).Click();
            Browser.Instance.AcceptAllert();
        }
    }
}
