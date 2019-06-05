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
	Then I click [MENU|BASIC INFO SETTINGS] on [PAGE|PERSONAL SETTINGS]
	Then I fill valid info in [TEXTBOX|REAL_NAME], [TEXTBOX|ID_CARD], [TEXTBOX|PHONE], [TEXTBOX|TITLE], [TEXTBOX|WEBSITE], [TEXTBOX|QQ] on [PAGE|BASIC INFO SETTINGS]
	Then I click [BUTTON|SAVE] on [PAGE|BASIC INFO SETTINGS]
	Then I can see [MESSAGE|BASIC INFORMATION SAVED SUCCESSFULLY] on [PAGE|BASIC INFO SETTINGS]
	Then I close the browser

@Invalid
Scenario: Fill with invalid info
	Given I am in home page
	Then I click LINK of LOGIN
	Then I input valid username and password, and make sure i have checked REMEMBER ME
	Then I can see the avatar on home page
	Then I move mouse on the avatar
	Then I click PERSONAL SETTINGS
	Then I click [MENU|BASIC INFO SETTINGS] on [PAGE|PERSONAL SETTINGS]
	Then I fill invalid info in [TEXTBOX|REAL_NAME], [TEXTBOX|ID_CARD], [TEXTBOX|PHONE], [TEXTBOX|TITLE], [TEXTBOX|WEBSITE], [TEXTBOX|QQ] on [PAGE|BASIC INFO SETTINGS]
	Then I click [BUTTON|SAVE] on [PAGE|BASIC INFO SETTINGS]
	Then I can see [ERROR MESSAGE|REAL_NAME], [ERROR MESSAGE|ID_CARD], [ERROR MESSAGE|PHONE], [ERROR MESSAGE|TITLE], [ERROR MESSAGE|WEBSITE], [ERROR MESSAGE|QQ] on [PAGE|BASIC INFO SETTINGS]
	Then I close the browser