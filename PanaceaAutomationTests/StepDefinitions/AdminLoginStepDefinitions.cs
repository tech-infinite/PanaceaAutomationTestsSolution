using System;
using OpenQA.Selenium;
using PanaceaAutomationTests.PageObjects;
using PanaceaAutomationTests.Pages;
using Reqnroll;

namespace PanaceaAutomationTests.StepDefinitions
{
    [Binding]
    public class AdminLoginStepDefinitions
    {
       
        private readonly AdminLoginPage _adminLoginPage;
        private readonly HomePage _homePage;

        public AdminLoginStepDefinitions(IWebDriver driver)
        {
             _adminLoginPage = new AdminLoginPage(driver);
        }

        [Given("the admin is on the login page")]
        public void GivenTheAdminIsOnTheLoginPage()
        {
            _homePage.ScrollToAdminSection();
            _adminLoginPage.ClickLogin();
        }

        [When("the admin enters valid credentials")]
        public void WhenTheAdminEntersValidCredentials()
        {
            _adminLoginPage.EnterUsername("admin1");
            _adminLoginPage.EnterPassword("password123");
            _adminLoginPage.ClickLogin();
        }

       
    }
}
