using Home12.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Home12
{
    public class BaseTest
    {

        [SetUp]
        public void Setup()
        {
            Browser.Instance.NavigateToUrl("http://the-internet.herokuapp.com/");
        }

        [TearDown]
        public void TearDown()
        {
            Browser.Instance.CloseBrowser();
        }

    }
}