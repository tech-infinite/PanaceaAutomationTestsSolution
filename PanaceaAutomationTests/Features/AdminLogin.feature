Feature: Admin Login
  
  As an unauthorised user
I should not be able to log in to the admin area
so that restricted functionality remains secure.

  Background:
    Given the user is on the admin login page


  Scenario: Admin login fails with invalid credentials
    When the admin enters invalid credentials
    And submits the login form
    Then an authentication error message should be displayed
   # And the admin should remain on the login page
