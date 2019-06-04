Feature: AvatarSettings
	In order to personalization
	As a user
	I want to edit my profile

@Update Avatar
Scenario: Update AVATAR
	Given I am in home page
	Then I click LINK of LOGIN
	Then I input valid username and password, and make sure i have checked REMEMBER ME
	Then I can see the avatar on home page
	Then I move mouse on the avatar
	Then I click PERSONAL SETTINGS
	Then I click [MENU] AVATAR SETTINGS
	Then I click UPLOAD NEW AVATAR
	Then I click a picture and click open
	Then I click SAVE