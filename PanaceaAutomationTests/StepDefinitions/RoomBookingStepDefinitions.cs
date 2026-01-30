using System;
using NUnit.Framework;
using OpenQA.Selenium;
using PanaceaAutomationTests.Pages;
using PanaceaAutomationTests.Pages.PanaceaAutomationTests.Pages;
using Reqnroll;

namespace PanaceaAutomationTests.StepDefinitions
{
    [Binding]
    public class RoomBookingStepDefinitions
    {
        private readonly IWebDriver _driver;
        private readonly HomePage _homePage;
        private readonly BookingPage _bookingPage;
        private readonly RoomsPage _roomsPage;

        public RoomBookingStepDefinitions(IWebDriver driver)
        {
            _homePage = new HomePage(driver);
            _bookingPage = new BookingPage(driver);
            _roomsPage = new RoomsPage(driver);
        }

        [Given("the user navigates to the hotel booking page")]
        public void GivenTheUserNavigatesToTheHotelBookingPage()
        {
           _homePage.NavigateToHomePage();
            _homePage.ScrollToBookingSection();
            Assert.That(_homePage.IsBookingSectionVisible(), Is.True, "Booking section was not visible on the homepage.");
        }



        [When("the user enters valid check-in and check-out dates")]
        public void WhenTheUserEntersValidCheck_InAndCheck_OutDates()
        {
            var checkIn = DateTime.Today.AddDays(1).ToString("dd-MM-yyyy");
            var checkOut = DateTime.Today.AddDays(3).ToString("dd-MM-yyyy");
            
            _bookingPage.EnterCheckInDate(checkIn);
            _bookingPage.EnterCheckOutDate(checkOut);

        }

        [When("the user clicks Check Availability")]
        public void WhenTheUserClicksCheckAvailability()
        {
            _bookingPage.ClickCheckAvailability();
           
        }

        [Then("available rooms should be displayed")]
        public void ThenAvailableRoomsShouldBeDisplayed()
        {
            Assert.That(_roomsPage.AreRoomsDisplayed(), Is.True, "No available rooms are displayed.");
        }

        //[Given("the page dispalys available rooms")]
        //public void GivenThePageDispalysAvailableRooms()
        //{
        //    Assert.That(_roomsPage.AreRoomsDisplayed(), Is.True, "No rooms are displayed on the page.");
        //}

        
        [When("the user selects a room")]
        public void WhenTheUserSelectsARoom()
        {
            _roomsPage.ClickFirstBookNowButton(); // method in RoomsPage
            Assert.That(_bookingPage.IsBookingFormVisible(), Is.True, "Booking form did not appear.");
        }

        [When("the user enters valid booking dates")]
        public void WhenTheUserEntersValidBookingDates()
        {
            Assert.That(_bookingPage.GetPricePerNight(), Is.Not.Empty, "Room price not displayed.");
        }

        [When("the user provides valid guest details")]
        public void WhenTheUserProvidesValidGuestDetails()
        {
            _bookingPage.EnterFirstName("John");
            _bookingPage.EnterLastName("Doe");
            _bookingPage.EnterEmail("john.doe@test.com");
            _bookingPage.EnterPhone("07123456789");

            Assert.That(_bookingPage.AreAllFormFieldsVisible(), Is.True, "Booking form fields missing.");
        }

        [When("the user submits the booking")]
        public void WhenTheUserSubmitsTheBooking()
        {
            _bookingPage.ClickReserveNow();
        }

        [Then("the booking should be confirmed successfully")]
        public void ThenTheBookingShouldBeConfirmedSuccessfully()
        {
            Assert.That(_bookingPage.IsBookingSuccessful(), Is.True, "Booking confirmation header not displayed.");
            Assert.That(_bookingPage.AreConfirmedDatesDisplayed(), Is.True, "Booking confirmation message not displayed.");
        }

        [When("the user clicks cancel on the booking form")]
        public void WhenTheUserClicksCancelOnTheBookingForm()
        {
            Assert.That(_bookingPage.IsBookingFormVisible(), Is.True, "Booking form is not visible to cancel.");
            _bookingPage.ClickCancel();

        }

        [Then("the booking form should be closed")]
        public void ThenTheBookingFormShouldBeClosed()
        {
            Assert.That(!_bookingPage.IsBookingFormVisible(), Is.True, "Booking form is still visible after canceling.");
        }

        [Then("the user should return to the rooms section")]
        public void ThenTheUserShouldReturnToTheRoomsSection()
        {
            Assert.That(_roomsPage.AreRoomsDisplayed(), Is.True, "Rooms section is not visible after canceling booking.");
        }


    }
}
