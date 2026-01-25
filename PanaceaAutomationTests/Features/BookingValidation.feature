Feature: BookingValidation

Feature: Booking form validation
  As a guest
  I want the booking form to validate my input
  So that I am informed when required information is missing


Scenario: User attempts to book without mandatory guest details
  Given the user has selected a room
  When the user submits the booking without entering required guest details
  Then an appropriate error message should be displayed
