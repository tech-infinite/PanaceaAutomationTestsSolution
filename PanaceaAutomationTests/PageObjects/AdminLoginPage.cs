using OpenQA.Selenium;
using PanaceaAutomationTests.Pages;
using Reqnroll.Bindings.Discovery;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaceaAutomationTests.PageObjects
{
    public class AdminLoginPage : BasePage
    {
        private readonly By loginFormHeader = By.XPath("//h2[contains(text(),'Login')]");
        private readonly By usernameInput = By.Id("username");
        private readonly By passwordInput = By.Id("password");
        private readonly By loginButton = By.Id("doLogin");
        private readonly By errorMessage = By.CssSelector(".alert-danger");

        public AdminLoginPage(IWebDriver driver) : base(driver) { }


        public void WaitForAdminPageToLoad()
        {
            wait.Until(driver => driver.Url.Contains("Login"));
        }

        public bool IsLoginFormDisplayed()
        {
            try
            {
                wait.Until(ExpectedConditions.ElementExists(loginFormHeader));
                wait.Until(driver => driver.Url.Contains("Login")); 
                return driver.FindElement(loginFormHeader).Displayed;
            }
            catch
            {
                return false;
            }
        }

        public void EnterUsername(string username) => SendKeys(usernameInput, username);
        public void EnterPassword(string password) => SendKeys(passwordInput, password);
        public void ClickLogin() => ClickElement(loginButton);

        public string GetErrorMessage() => GetText(errorMessage);
    }


}
