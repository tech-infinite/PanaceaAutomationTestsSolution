using NUnit.Framework;
using OpenQA.Selenium;
using PanaceaAutomationTests.PageObjects;
using PanaceaAutomationTests.Pages;
using Reqnroll;
using Reqnroll.BoDi;


namespace PanaceaAutomationTests.StepDefinitions
{
    [Binding]
    public class HomeNavigationStepDefinitions
    {
        private readonly IWebDriver _driver;
        private readonly HomePage _homePage;
      
        public HomeNavigationStepDefinitions(IObjectContainer container) 
        {
            _driver = container.Resolve<IWebDriver>();
            _homePage = new HomePage(_driver);
            
        }

        [Given("the user is on the hotel booking homepage")]
        public void GivenTheUserIsOnTheHotelBookingHomepage()
        {
            _homePage.NavigateToHomePage();
        }


        [When("the user scrolls to the Rooms section")]
        public void WhenTheUserScrollsToTheRoomsSection()
        {
            _homePage.ScrollToRoomsSection();          
        }

        [Then("the Rooms section should be visible")]
        public void ThenTheRoomsSectionShouldBeVisible()
        {
            Assert.That(_homePage.IsRoomsSectionVisible(), Is.True);
                
        }
        
        [When("the user scrolls to the Location section")]
        public void WhenTheUserScrollsToTheLocationSection()
        {
            _homePage.ScrollToLocationSection();
        }

        [Then("the Location section should be visible")]
        public void ThenTheLocationSectionShouldBeVisible()
        {
            _homePage.ScrollToLocationSection();
            Assert.That(_homePage.IsLocationSectionVisible(), Is.True);
        }

        [Then("the location map or details should be displayed")]
        public void ThenTheLocationMapOrDetailsShouldBeDisplayed()
        {
             Assert.That(_homePage.IsLocationHeaderVisible(), Is.True);
        }

        [When("the user scrolls to the Contact section")]
        public void WhenTheUserScrollsToTheContactSection()
        {
            _homePage.ScrollToContactSection();
            
        }

        [Then("the Contact section should be visible")]
        public void ThenTheContactSectionShouldBeVisible()
        {
            Assert.That(_homePage.IsContactSectionVisible(), Is.True);
        }

       
        [When("the user scrolls to the Admin section")]
        public void WhenTheUserScrollsToTheAdminSection()
        {
            _homePage.ScrollToAdminSection();
            _homePage.ClickAdminNavLink();
            
        }

        [Then("the Admin section should be visible")]
        public void ThenTheAdminSectionShouldBeVisible()
        {
            //_homePage.ScrollToAdminSection();
            Assert.That(_homePage.IsAdminSectionVisible(), Is.True);
        }

    }
}
