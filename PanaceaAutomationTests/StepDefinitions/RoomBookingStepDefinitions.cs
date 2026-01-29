using System;
using NUnit.Framework;
using OpenQA.Selenium;
using PanaceaAutomationTests.Pages;
using Reqnroll;

namespace PanaceaAutomationTests.StepDefinitions
{
    [Binding]
    public class RoomBookingStepDefinitions
    {
        private readonly HomePage _homePage;
        private readonly BookingPage _bookingPage;

        public RoomBookingStepDefinitions(IWebDriver driver)
        {
             _homePage = new HomePage(driver);
             _bookingPage = new BookingPage(driver);
        }

        [Given("the user is on the hotel booking homepage")]
        public void GivenTheUserIsOnTheHotelBookingHomepage()
        {
            _homePage.NavigateToHomePage();
            _homePage.ScrollToRoomsSection();
            Assert.That(_homePage.IsRoomsSectionVisible(), Is.True);
           
        }

        [Given("available rooms are displayed")]
        public void GivenAvailableRoomsAreDisplayed()
        {
            
        }

        //[When("the user selects a room")]
        //public void WhenTheUserSelectsARoom()
        //{
        //    _roomsPage.GetRoomNames();
        //}

        //[When("the user enters valid booking dates")]
        //public void WhenTheUserEntersValidBookingDates()
        //{
            
        //}

        //[When("the user provides valid guest details")]
        //public void WhenTheUserProvidesValidGuestDetails()
        //{
        //    throw new PendingStepException();
        //}

        //[When("the user submits the booking")]
        //public void WhenTheUserSubmitsTheBooking()
        //{
        //    throw new PendingStepException();
        //}

        //[Then("the booking should be confirmed successfully")]
        //public void ThenTheBookingShouldBeConfirmedSuccessfully()
        //{
        //    throw new PendingStepException();
        //}

    }
}
