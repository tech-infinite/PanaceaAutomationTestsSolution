Feature: Admin Login
  As a hotel administrator
  I want to log into the admin portal
  So that I can manage rooms and bookings

  Background:
    Given the admin is on the login page


  Scenario: Admin login fails with invalid credentials
    When the admin enters invalid credentials
    And submits the login form
    Then an authentication error message should be displayed
    And the admin should remain on the login page
