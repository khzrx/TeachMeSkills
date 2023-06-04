using Home12.Core;
using OpenQA.Selenium;

namespace Home12
{
    internal class DownloadTests
    {
        [Test]
        public void DownloadTest()
        {
            Browser.Instance.NavigateToUrl("http://the-internet.herokuapp.com/download");
            Browser.Instance.Driver.FindElement(By.LinkText("sunset.jpg")).Click();
            Thread.Sleep(3000);
            Assert.IsNotNull(File.GetAttributes(DirectoryHelper.GetTestDataFolderPath() + "sunset.jpg"));
        }
    }
}
