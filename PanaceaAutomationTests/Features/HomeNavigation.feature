Feature: Homepage navigation
  As a user
  I want to navigate to different sections of the homepage
  So that I can view their content

  Background: 
	Given the user is on the hotel booking homepage

  Scenario: Navigate to Rooms section
    When the user scrolls to the Rooms section
    Then the Rooms section should be visible
    

  Scenario: Navigate to Location section
    When the user scrolls to the Location section
    Then the Location section should be visible
    And the location map or details should be displayed

  Scenario: Navigate to Contact section
    When the user scrolls to the Contact section
    Then the Contact section should be visible
    #And the contact information should be displayed

  Scenario: Navigate to Admin section 
    When the user scrolls to the Admin section
    Then the Admin section should be visible


    