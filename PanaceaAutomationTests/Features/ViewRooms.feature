Feature: ViewRooms

View Rooms feature. As a potential guest I should be able 
to view available hotel rooms so that I can decide whether 
to make a booking.


Scenario: User views available rooms 
	Given the user is on the hotel booking homepage
	Then the user should be able to view the list of available rooms
	And each room should display its name, price, and description



