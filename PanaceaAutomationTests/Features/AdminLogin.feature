Feature: AdminLogin

  As an admin I want to log into the admin page in order to manage hotel rooms and bookings

Scenario: Admin logs in with valid credentials
  Given the admin is on the login page
  When the admin enters valid credentials
  Then the admin dashboard should be displayed

