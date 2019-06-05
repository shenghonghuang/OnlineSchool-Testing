Feature: Register
	In order to use the system
	As a num-member
	I want to resiger as a user

@Invaild
Scenario: Login with invaild information
	Given I am in home page
	Then I click register
	Then I input invalid Email
	Then I can see error text about invalid Email
	Then I input invalid nick name
	Then I can see error text about nick name
	Then I input invalid password
	Then I can see error text about password
	Then I input invalid captcha code
	Then I can see error text about aptcha code
	Then I close the browser