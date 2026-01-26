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
            Assert.That(_homePage.IsHomePageDisplayed(), Is.True);
           
        }

        [Given("available rooms are displayed")]
        public void GivenAvailableRoomsAreDisplayed()
        {
            throw new PendingStepException();
        }

        [When("the user selects a room")]
        public void WhenTheUserSelectsARoom()
        {
            throw new PendingStepException();
        }

        [When("the user enters valid booking dates")]
        public void WhenTheUserEntersValidBookingDates()
        {
            throw new PendingStepException();
        }

        [When("the user provides valid guest details")]
        public void WhenTheUserProvidesValidGuestDetails()
        {
            throw new PendingStepException();
        }

        [When("the user submits the booking")]
        public void WhenTheUserSubmitsTheBooking()
        {
            throw new PendingStepException();
        }

        [Then("the booking should be confirmed successfully")]
        public void ThenTheBookingShouldBeConfirmedSuccessfully()
        {
            throw new PendingStepException();
        }

    }
}
