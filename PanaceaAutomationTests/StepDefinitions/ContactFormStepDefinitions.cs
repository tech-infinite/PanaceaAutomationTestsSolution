using System;
using NUnit.Framework;
using OpenQA.Selenium;
using PanaceaAutomationTests.PageObjects;
using PanaceaAutomationTests.Pages;
using Reqnroll;

namespace PanaceaAutomationTests.StepDefinitions
{
    [Binding]
    public class ContactFormStepDefinitions
    {
        private readonly ContactPage _contactPage;
        private readonly HomePage _homePage;
        public ContactFormStepDefinitions(IWebDriver driver)
        {
            _homePage = new HomePage(driver);
            _contactPage = new ContactPage(driver);
        }

        [Given("the user navigates to the Contact link")]
        public void GivenTheUserNavigatesToTheContactLink()
        {
            _homePage.NavigateToHomePage();
            _homePage.ScrollToContactSection();
            Assert.That(_contactPage.IsContactFormVisible(), Is.True);

        }

        [When("the user submits enquiry form with valid details")]
        public void WhenTheUserSubmitsEnquiryFormWithValidDetails()
        {
            _contactPage.EnterName("John Doe");
            _contactPage.EnterEmail("j.doe@qa.com");
            _contactPage.EnterPhone("0745822890");
            _contactPage.EnterSubject("Room Inquiry");
            _contactPage.EnterMessage("I would like to know more about your room options.");
            _contactPage.ClickSubmit();
        }

        [Then("an acknowledgement message should be displayed")]
        public void ThenAnAcknowledgementMessageShouldBeDisplayed()
        {
            Assert.That(_contactPage.IsSuccessMessageVisible(), Is.True);
        }
    }
}
