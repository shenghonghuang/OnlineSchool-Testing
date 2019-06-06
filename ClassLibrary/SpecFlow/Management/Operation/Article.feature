Feature: Article
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I am in home page
	Then I click LINK of LOGIN
	Then I fill administrator account in [TEXTBOX|USERNAME], [TEXTBOX|PASSWORD] and click [BUTTON|LOGIN] on [PAGE|LOGIN]
	Then I move mouse on the avatar
	Then I click [MENU|MANAGEMENT] ON [PAGE|HOME]
	Then I click [MENU|OPERATION] on [PAGE|MANAGEMENT]
	Then I click [MENU|ARTICLE] on [PAGE|OPERATION]
	Then I select EduSoho on [DROPDOWNLIST|CATEGORY] on [PAGE|ARTICLE]
	Then I click [BUTTON|SEARCH] on [PAGE|ARTICLE]
	Then I fill {WORLD} in [TEXTBOX|KEYWORD] on [PAGE|ARTICLE]
	Then I click [BUTTON|SEARCH] on [PAGE|ARTICLE]
	Then I clear [TEXTBOX|KEYWORD] on [PAGE|ARTICLE]
	Then I click [BUTTON|SEARCH] on [PAGE|ARTICLE]
	Then I select {HEADLINE} on [DROPDOWNLIST|ATTRIBUTE] on [PAGE|ARTICLE]
	Then I click [BUTTON|SEARCH] on [PAGE|ARTICLE]
	Then I select {PUBLISHED} on [DROPDOWNLIST|STATUS] on [PAGE|ARTICLE]
	Then I click [BUTTON|SEARCH] on [PAGE|ARTICLE]