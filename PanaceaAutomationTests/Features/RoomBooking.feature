Feature: RoomBooking

Feature: Book a hotel room
  As a guest
  I want to book a hotel room
  So that I can reserve accommodation for my stay

Background: 
    Given the user navigates to the hotel booking page
    #And the page dispalys available rooms


Scenario: User checks room availability
  When the user enters valid check-in and check-out dates
  And the user clicks Check Availability
  Then available rooms should be displayed


Scenario: User successfully books a room
  When the user selects a room
  And the user enters valid booking dates
  And the user provides valid guest details
  And the user submits the booking
  Then the booking should be confirmed successfully

 
 Scenario: User cancels the booking process
    When the user selects a room
    And the user clicks cancel on the booking form
    Then the booking form should be closed
    And the user should return to the rooms section