Feature: Login
	In order to learn online
	As a member
	I need to login in with my account

@LoginSuccessful
Scenario: LoginWithValidInfo
	Given I am in home page
	Then I click LINK of LOGIN
	Then I input valid username and password, and make sure i have checked REMEMBER ME
	Then I can see the avatar on home page
	Then I close the browser


@LoginUnsuccessful
Scenario: LoginWithInValidInfo
	Given I am in home page
	Then I click LINK of LOGIN
	Then I input invalid username and password
	Then I can see the error notification on login page
	Then I close the browser
