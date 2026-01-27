Feature: ContactForm

As a user I should be able to fill in 
the contact form in order to submit an
enquiry.


Scenario: User submits the enquiry form successfully
	Given the user navigates to the Contact link
	When the user submits enquiry form with valid details
	Then an acknowledgement message should be displayed
