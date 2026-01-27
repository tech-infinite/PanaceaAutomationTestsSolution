using System;
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
            _homePage.ScrollToContactSection();
            
        }

        [When("the user submits enquiry form with valid details")]
        public void WhenTheUserSubmitsEnquiryFormWithValidDetails()
        {
            throw new PendingStepException();
        }

        [Then("an acknowledgement message should be displayed")]
        public void ThenAnAcknowledgementMessageShouldBeDisplayed()
        {
            throw new PendingStepException();
        }
    }
}
