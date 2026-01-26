Feature: RoomBooking

Feature: Book a hotel room
  As a guest
  I want to book a hotel room
  So that I can reserve accommodation for my stay


Scenario: User successfully books a room
  Given the user is on the hotel booking homepage
  And available rooms are displayed
  When the user selects a room
  And the user enters valid booking dates
  And the user provides valid guest details
  And the user submits the booking
  Then the booking should be confirmed successfully

  #Scenario: User attempts to book without mandatory guest details
  #Given the user has selected a room
  #When the user submits the booking without entering required guest information
  #Then an appropriate validation message should be displayed
