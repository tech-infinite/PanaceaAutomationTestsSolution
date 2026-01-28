Feature: Viewing Location Details

  Background:
    Given I am on the Shady Meadows "Our Location" page

  Scenario: Viewing the map and contact information
    Then the location map should be visible with its pin and attribution
    And the contact information should be displayed with address, phone, and email
    And the "Getting Here" description should be visible