Feature: Logout
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Logout
Scenario: Logout if Logined
	Given I am in home page
	Then I click LINK of LOGIN
	Then I input valid username and password, and make sure i have checked REMEMBER ME
	Then I can see the avatar on home page
	Then I move mouse on the avatar
	Then I click Logout
	Then I can see the login page
	Then I close the browser
