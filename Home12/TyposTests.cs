using OpenQA.Selenium;

namespace Home12
{
    internal class TyposTests : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            driver.FindElement(By.LinkText("Typos")).Click();
        }

        [Test]
        [Description("Homework. Task 3-f.")]
        public void CheckTextInParagraph()
        {
            List<IWebElement> paragraphes = driver.FindElements(By.TagName("p")).ToList();
            Assert.IsNotEmpty(paragraphes);

            string actualTextFirst = paragraphes[0].Text;
            string actualTextSecond = paragraphes[1].Text;

            string expectedTextFirst = "This example demonstrates a typo being introduced. It does it randomly on each page load.";
            string expectedTextSecond = "Sometimes you'll see a typo, other times you won't.";

            Assert.AreEqual(expectedTextFirst, actualTextFirst);
            Assert.AreEqual(expectedTextSecond, actualTextSecond);
        }
    }
}
