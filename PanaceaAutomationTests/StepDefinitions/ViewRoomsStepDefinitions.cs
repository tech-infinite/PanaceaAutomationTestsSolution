using System;
using OpenQA.Selenium;
using PanaceaAutomationTests.Pages;
using Reqnroll;

namespace PanaceaAutomationTests.StepDefinitions
{
    [Binding]
    public class ViewRoomsStepDefinitions
    {
        private readonly RoomsPage _roomsPage;
        public ViewRoomsStepDefinitions(IWebDriver driver)
        {
             _roomsPage = new RoomsPage(driver);
        }
        [Then("the user should be able to view the list of available rooms")]
        public void ThenTheUserShouldBeAbleToViewTheListOfAvailableRooms()
        {
            
        }

        [Then("each room should display its name, price, and description")]
        public void ThenEachRoomShouldDisplayItsNamePriceAndDescription()
        {
            
        }

        [When("the user applies a room type and price filter")]
        public void WhenTheUserAppliesARoomTypeAndPriceFilter()
        {
            
        }

        [Then("only rooms matching the selected criteria should be displayed")]
        public void ThenOnlyRoomsMatchingTheSelectedCriteriaShouldBeDisplayed()
        {
           
        }
    }
}
