using System;
using Reqnroll;

namespace PanaceaAutomationTests.StepDefinitions
{
    [Binding]
    public class BookingValidationStepDefinitions
    {
        [Given("the user has selected a room")]
        public void GivenTheUserHasSelectedARoom()
        {
            throw new PendingStepException();
        }

        [When("the user submits the booking without entering required guest details")]
        public void WhenTheUserSubmitsTheBookingWithoutEnteringRequiredGuestDetails()
        {
            throw new PendingStepException();
        }

        [Then("an appropriate error message should be displayed")]
        public void ThenAnAppropriateErrorMessageShouldBeDisplayed()
        {
            throw new PendingStepException();
        }
    }
}
