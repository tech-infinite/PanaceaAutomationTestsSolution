using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace PanaceaAutomationTests.Pages
{
    public class BasePage
    {
        protected readonly IWebDriver driver;
        protected WebDriverWait wait;

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
            var element = wait.Until(ExpectedConditions.ElementToBeClickable(by));

            // Scroll the element to the center of the viewport
            ((IJavaScriptExecutor)driver).ExecuteScript(
                "arguments[0].scrollIntoView({behavior: 'instant', block: 'center', inline: 'center'});",
                element
            );

            Thread.Sleep(150); // allow layout to settle

            try
            {
                element.Click();
            }
            catch (ElementClickInterceptedException)
            {
                // Fallback: JS click bypasses overlays
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", element);
            }
        }



        protected void SendKeys(By by, string text)
        {
            var element = FindClickableElement(by);
            element.Clear();
            element.SendKeys(text);
        }

        protected string GetText(By by)
        {
            return FindElement(by).Text;
        }

        protected bool WaitForText(By by, string partialText, int timeout = 10)
        {
            return wait.Until(driver =>
                driver.FindElement(by).Text.Contains(partialText));
        }

    }
}
