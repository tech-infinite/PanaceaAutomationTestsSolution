using System;
using NUnit.Framework;
using OpenQA.Selenium;
using PanaceaAutomationTests.Pages;
using Reqnroll;

namespace PanaceaAutomationTests.StepDefinitions
{
    [Binding]
    public class ViewRoomsStepDefinitions
    {
        private readonly HomePage _homePage;
        private readonly RoomsPage _roomsPage;

        public ViewRoomsStepDefinitions(IWebDriver driver)
        {
            _homePage= new HomePage(driver);
            _roomsPage = new RoomsPage(driver);
        }


        [Given("the user naviagtes to the Rooms section of the hotel website")]
        public void GivenTheUserNaviagtesToTheRoomsSectionOfTheHotelWebsite()
        {
            _homePage.NavigateToHomePage();
            _homePage.ScrollToRoomsSection();
            Assert.That(_homePage.IsRoomsSectionVisible(), Is.True, "Rooms section was not visible on the homepage.");
        }


        [Given("available rooms are displayed")]
        public void GivenAvailableRoomsAreDisplayed()
        {
            
            _roomsPage.AreRoomsDisplayed();
            Assert.That(_roomsPage.AreRoomsDisplayed(), Is.True);
        }


        [Then("the user should be able to view the list of available rooms")]
        public void ThenTheUserShouldBeAbleToViewTheListOfAvailableRooms()
        {
            Assert.That(_roomsPage.AreRoomsDisplayed(), Is.True, "No room cards are displayed on the page.");


        }

        [Then("each room should display its name, price, and description")]
        public void ThenEachRoomShouldDisplayItsNamePriceAndDescription()
        {
            Assert.That(_roomsPage.RoomsHaveNamePriceAndDescription(), Is.True,
    "Some rooms are missing name, price, or description.");

        }


    }
}
