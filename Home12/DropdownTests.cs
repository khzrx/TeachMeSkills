﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Home12
{
    internal class DropdownTests : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            driver.FindElement(By.LinkText("Dropdown")).Click();
        }

        [Test]
        [Description("Test from lesson")]
        public void SelectOption()
        {
            SelectElement select = new(driver.FindElement(By.Id("dropdown")));

            select.SelectByIndex(2);
            select.SelectByText("Please select an option");
        }

        [Test]
        [Description("Homework. Task 3-c.")]
        public void CheckAndSelectOptions()
        {
            SelectElement select = new(driver.FindElement(By.Id("dropdown")));
            Assert.IsNotNull(select);

            select.SelectByValue("1");
            Assert.IsTrue(driver.FindElement(By.XPath("//option[text()='Option 1']")).Selected);

            select.SelectByValue("2");
            Assert.IsTrue(driver.FindElement(By.XPath("//option[text()='Option 2']")).Selected);
        }
    }
}