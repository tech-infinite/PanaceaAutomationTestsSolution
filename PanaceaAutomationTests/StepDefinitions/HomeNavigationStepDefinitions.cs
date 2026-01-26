using NUnit.Framework;
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
            _homePage.ScrollToRoomsSection();          
        }

        [Then("the Rooms section should be visible")]
        public void ThenTheRoomsSectionShouldBeVisible()
        {
            Assert.That(_homePage.IsRoomsSectionVisible(), Is.True);
                
        }

        [Then("the list of available rooms should be displayed")]
        public void ThenTheListOfAvailableRoomsShouldBeDisplayed()
        {
            
        }

        [When("the user scrolls to the Amenities section")]
        public void WhenTheUserScrollsToTheAmenitiesSection()
        {
            _homePage.ScrollToAmenitiesSection();
        }

        [Then("the Amenities section should be visible")]
        public void ThenTheAmenitiesSectionShouldBeVisible()
        {
            _homePage.ScrollToAmenitiesSection();
        }

        [Then("the amenities list should be displayed")]
        public void ThenTheAmenitiesListShouldBeDisplayed()
        {
            Assert.That(_homePage.IsAmenitiesSectionVisible(), Is.True);
        }

        [When("the user scrolls to the Location section")]
        public void WhenTheUserScrollsToTheLocationSection()
        {
            _homePage.ScrollToLocationSection();
        }

        [Then("the Location section should be visible")]
        public void ThenTheLocationSectionShouldBeVisible()
        {
            Assert.That(_homePage.IsLocationSectionVisible(), Is.True);
        }

        [Then("the location map or details should be displayed")]
        public void ThenTheLocationMapOrDetailsShouldBeDisplayed()
        {
            
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

        [Then("the contact information should be displayed")]
        public void ThenTheContactInformationShouldBeDisplayed()
        {
            
        }

        [When("the user scrolls to the Admin section")]
        public void WhenTheUserScrollsToTheAdminSection()
        {
            _homePage.ScrollToAdminSection();
        }

        [Then("the Admin section should be visible")]
        public void ThenTheAdminSectionShouldBeVisible()
        {
            Assert.That(_homePage.IsLoginFormVisible(), Is.True);
        }

    }
}
