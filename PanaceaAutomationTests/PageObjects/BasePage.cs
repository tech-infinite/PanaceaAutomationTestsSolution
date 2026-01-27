using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace PanaceaAutomationTests.Pages
{
    public class BasePage
    {
        protected readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        protected IWebElement FindElement(By by)
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        protected IWebElement FindClickableElement(By by)
        {
            return wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        protected void ClickElement(By by)
        {
            FindClickableElement(by).Click();
        }

        protected void SendKeys(By by, string text)
        {
            var element = FindClickableElement(by);
            element.Clear();
            element.SendKeys(text);
        }

        protected void GetText(By by)
        {
            FindClickableElement(by).Click();
        }

        protected bool WaitForText(By by, string partialText, int timeout = 10)
        {
            return wait.Until(driver =>
                driver.FindElement(by).Text.Contains(partialText));
        }

    }
}
