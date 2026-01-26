using OpenQA.Selenium;
using PanaceaAutomationTests.PageObjects;
using PanaceaAutomationTests.Pages;
using Reqnroll;
using Reqnroll.BoDi;
using System;

namespace PanaceaAutomationTests.StepDefinitions
{
    [Binding]
    public class HomeNavigationStepDefinitions
    {
        private readonly IWebDriver _driver;
        private readonly HomePage _homePage;
        private readonly RoomsPage _roomsPage;
        private readonly AmenitiesPage _amenitiesPage;
        private readonly LocationPage _locationPage;
        private readonly ContactPage _contactPage;

        public HomeNavigationStepDefinitions(IObjectContainer container) 
        {
            _driver = container.Resolve<IWebDriver>();
            _homePage = new HomePage(_driver);
            _roomsPage = new RoomsPage(_driver);
            _amenitiesPage = new AmenitiesPage(_driver);
            _locationPage = new LocationPage(_driver);
            _contactPage = new ContactPage(_driver);
        }

        [When("the user scrolls to the Rooms section")]
        public void WhenTheUserScrollsToTheRoomsSection()
        {
            
        }

        [Then("the Rooms section should be visible")]
        public void ThenTheRoomsSectionShouldBeVisible()
        {
            
        }

        [Then("the list of available rooms should be displayed")]
        public void ThenTheListOfAvailableRoomsShouldBeDisplayed()
        {
            
        }

        [When("the user scrolls to the Amenities section")]
        public void WhenTheUserScrollsToTheAmenitiesSection()
        {
            
        }

        [Then("the Amenities section should be visible")]
        public void ThenTheAmenitiesSectionShouldBeVisible()
        {
            
        }

        [Then("the amenities list should be displayed")]
        public void ThenTheAmenitiesListShouldBeDisplayed()
        {
            
        }

        [When("the user scrolls to the Location section")]
        public void WhenTheUserScrollsToTheLocationSection()
        {
            
        }

        [Then("the Location section should be visible")]
        public void ThenTheLocationSectionShouldBeVisible()
        {
            
        }

        [Then("the location map or details should be displayed")]
        public void ThenTheLocationMapOrDetailsShouldBeDisplayed()
        {
            
        }

        [When("the user scrolls to the Contact section")]
        public void WhenTheUserScrollsToTheContactSection()
        {
            
        }

        [Then("the Contact section should be visible")]
        public void ThenTheContactSectionShouldBeVisible()
        {
            
        }

        [Then("the contact information should be displayed")]
        public void ThenTheContactInformationShouldBeDisplayed()
        {
            
        }
    }
}
