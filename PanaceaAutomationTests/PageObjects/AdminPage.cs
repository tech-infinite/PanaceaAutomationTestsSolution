using OpenQA.Selenium;
using PanaceaAutomationTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaceaAutomationTests.PageObjects
{
    public class AdminPage : BasePage
    {
        private readonly By userNameField = By.Id("username");
        private readonly By passwordField = By.Id("password");
        private readonly By loginButton = By.CssSelector("button[type='submit']");

        public AdminPage(IWebDriver driver) : base(driver)
        {

        }
            
        
    }
}
