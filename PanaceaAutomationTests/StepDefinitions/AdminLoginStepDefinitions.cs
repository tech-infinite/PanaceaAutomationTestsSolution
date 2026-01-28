using System;
using NUnit.Framework;
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
            _homePage = new HomePage(driver);
            _adminLoginPage = new AdminLoginPage(driver);
        }

        [Given("the user is on the admin login page")]
        public void GivenTheUserIsOnTheAdminLoginPage()
        {
            _homePage.NavigateToHomePage();
            _homePage.ScrollToAdminSection();
            _homePage.ClickAdminNavLink();
            Assert.That(_adminLoginPage.IsLoginFormDisplayed(), Is.True, "Admin login form is not displayed.");
        }

        [When("the admin enters invalid credentials")]
        public void WhenTheAdminEntersInvalidCredentials()
        {
            _adminLoginPage.EnterUsername("user1");
            _adminLoginPage.EnterPassword("admin1");
        }

        [When("submits the login form")]
        public void WhenSubmitsTheLoginForm()
        {
            _adminLoginPage.ClickLogin();
        }


        [Then("an authentication error message should be displayed")]
        public void ThenAnAuthenticationErrorMessageShouldBeDisplayed()
        {
            Assert.That(_adminLoginPage.GetErrorMessage(), Is.True);
        }

        


    }
}
