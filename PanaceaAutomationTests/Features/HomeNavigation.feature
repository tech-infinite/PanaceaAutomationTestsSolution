Feature: Homepage navigation
  As a user
  I want to navigate to different sections of the homepage
  So that I can view their content

  Scenario: Navigate to Rooms section
    Given the user is on the hotel booking homepage
    When the user scrolls to the Rooms section
    Then the Rooms section should be visible
    And the list of available rooms should be displayed

  Scenario: Navigate to Amenities section
    Given the user is on the hotel booking homepage
    When the user scrolls to the Amenities section
    Then the Amenities section should be visible
    And the amenities list should be displayed

  Scenario: Navigate to Location section
    Given the user is on the hotel booking homepage
    When the user scrolls to the Location section
    Then the Location section should be visible
    And the location map or details should be displayed

  Scenario: Navigate to Contact section
    Given the user is on the hotel booking homepage
    When the user scrolls to the Contact section
    Then the Contact section should be visible
    And the contact information should be displayed
