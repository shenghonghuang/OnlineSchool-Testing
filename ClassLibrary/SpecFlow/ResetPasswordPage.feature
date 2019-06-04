Feature: ResetPasswordPage
	In order to login the system
	As I forget the password
	I want to reset the password

@Wrong format
Scenario: Use error format Email
	Given I am in home page
	Then I click login
	Then I click LINK of RESET PASSWORD
	Then I input a error format Email
	Then I click BUTTON of RESET PASSWORD button
	Then I can see the error notification for error format Email

@Nonexistent
Scenario: Use nonexistent Email
	Given I am in home page
	Then I click login
	Then I click LINK of RESET PASSWORD
	Then I input a nonexistent Email
	Then I click BUTTON of RESET PASSWORD button
	Then I can see the error notification for nonexistent Email
