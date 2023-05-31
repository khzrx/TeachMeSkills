﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SauceDemo
{
    internal class WaitHelper
    {
        public static void WaitElement(WebDriver driver, By by, int time = 10)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(time)).Until(element => element.FindElement(by));
        }

        public static void WaitElementWithTitle(WebDriver driver, By by, string text, int time = 10)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(time)).
                Until(element => element.FindElement(by).Text.ToLower() == text.ToLower());
        }

        public static void WaitElements(WebDriver driver, By by, int count, int time = 10)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(time))
                .Until(element => element.FindElements(by).Count == count);
        }
    }
}
