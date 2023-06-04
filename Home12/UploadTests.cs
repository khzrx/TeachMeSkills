using Home12.Core;
using OpenQA.Selenium;

namespace Home12
{
    internal class UploadTests : BaseTest
    {
        [Test]
        public void UploadTest()
        {
            Browser.Instance.NavigateToUrl("https://the-internet.herokuapp.com/upload");

            var elem = Browser.Instance.Driver.FindElement(By.Id("file-upload"));

            elem.SendKeys(DirectoryHelper.GetTestDataFolderPath() + "testFileToUpload.txt");

            var uploadedFileName = elem.GetAttribute("value");

            Assert.IsTrue(uploadedFileName.Contains("testFileToUpload.txt"));
        }
    }
}
