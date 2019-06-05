Feature: BasicInfoSettings
	In order to personalization
	As a user
	I want to edit my profile

@Valid
Scenario: Fill with valid info
	Given I am in home page
	Then I click LINK of LOGIN
	Then I input valid username and password, and make sure i have checked REMEMBER ME
	Then I can see the avatar on home page
	Then I move mouse on the avatar
	Then I click PERSONAL SETTINGS
	Then I click [MENU | BASIC INFO SETTINGS] on [PAGE | PERSONAL SETTINGS]
	Then I fill valid info in [TEXTBOX | REALNAME, ID, PHONE, TITLE, WEBSITE, QQ] on [PAGE | BASIC INFO SETTINGS]
	Then I click [BUTTON | SAVE] on [PAGE | BASIC INFO SETTINGS]
	Then I can see [MESSAGE | BASIC INFORMATION SAVED SUCCESSFULLY] on [PAGE | BASIC INFO SETTINGS]

@Invalid
Scenario: Fill with invalid info
	Given I am in home page
	Then I click LINK of LOGIN
	Then I input valid username and password, and make sure i have checked REMEMBER ME
	Then I can see the avatar on home page
	Then I move mouse on the avatar
	Then I click PERSONAL SETTINGS
	Then I click [MENU | BASIC INFO SETTINGS] on [PAGE | PERSONAL SETTINGS]
	Then I fill invalid info in [TEXTBOX | REALNAME, ID, PHONE, TITLE, WEBSITE, QQ] on [PAGE | BASIC INFO SETTINGS]
	Then I click [BUTTON | SAVE] on [PAGE | BASIC INFO SETTINGS]
	Then I can see [MESSAGE | ERROR : INVALID REALNAME, ID, PHONE, TITLE, WEBSITE, QQ] on [PAGE | BASIC INFO SETTINGS]