using OpenQA.Selenium;
using PanaceaAutomationTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaceaAutomationTests.PageObjects
{
    public class AdminLoginPage : BasePage
    {
        // Form fields selectors
        private readonly By usernameInput = By.Id("username");
        private readonly By passwordInput = By.Id("password");
        private readonly By loginButton = By.Id("doLogin");
        private readonly By loginHeader = By.XPath("//h2[text()='Login']");
        private readonly By frontPage = By.Id("frontPageLink");
        private readonly By logoutButton = By.XPath("//button[text()='Logout']");


        public AdminLoginPage(IWebDriver driver) : base(driver) { }

        public bool IsLoginPageDisplayed()
        {
            WaitForElement(loginHeader);
            return FindElement(loginHeader).Displayed;
        }

        public void EnterUsername(string username)
        {
            SendKeys(usernameInput, username);
        }

        public void EnterPassword(string password)
        {
            SendKeys(passwordInput, password);
        }

        public void ClickLogin()
        {
            ClickElement(loginButton);
        }

        public void LoginAs(string username, string password)
        {
            EnterUsername(username);
            EnterPassword(password);
            ClickLogin();
        }
    }

}
