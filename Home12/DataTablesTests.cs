using OpenQA.Selenium;

namespace Home12
{
    internal class DataTablesTests : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            driver.FindElement(By.LinkText("Sortable Data Tables")).Click();
        }

        [Test]
        [Description("Homework. Task 3-e.")]
        public void AddTwoButtonsRemoveOne()
        {
            Assert.AreEqual(driver.FindElement(By.XPath("//table[@id='table1']//tr[1]//td[1]")).Text, "Smith");
            Assert.AreEqual(driver.FindElement(By.XPath("//table[@id='table1']//tr[2]//td[2]")).Text, "Frank");
            Assert.AreEqual(driver.FindElement(By.XPath("//table[@id='table2']//tr[3]//td[3]")).Text, "jdoe@hotmail.com");
        }
    }
}
