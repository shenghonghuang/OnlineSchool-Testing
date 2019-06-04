Feature: Profile
	In order to personalization
	As a user
	I want to edit my profile

@Update Avatar Icon
Scenario: Choose and upload a new avatar icon
	Given I am in home page
	Then I click LINK of LOGIN
	Then I input valid username and password, and make sure i have checked REMEMBER ME
	Then I can see the avatar on home page
	Then I move mouse on the avatar
	Then I click PERSONAL SETTINGS
	Then I click AVATAR SETTINGS
	Then I click UPLOAD NEW AVATAR
	Then I click a picture and click open
	Then I click SAVE