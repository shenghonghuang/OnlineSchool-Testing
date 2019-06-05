Feature: Class Orders
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@ViewClassOrders
Scenario: View Class Orders
	Given I am in home page
	Then I click LINK of LOGIN
	Then I fill administrator account in [TEXTBOX|USERNAME], [TEXTBOX|PASSWORD] and click [BUTTON|LOGIN] on [PAGE|LOGIN]
	Then I move mouse on the avatar
	Then I click [MENU|MANAGEMENT] ON [PAGE|HOME]
	Then I click [MENU|ORDER] ON [PAGE|MANAGEMENT]
	Then I click [MENU|CLASS ORDER] ON [MENU|ORDER]
	Then I click [BUTTON|SEARCH] ON [PAGE|CLASS ORDER]
	Then I select 2017-12-14 22:51 on [DATETIMEPICKER|START DATE TIME] on [PAGE|CLASS ORDER]
	Then I click [BUTTON|SEARCH] ON [PAGE|CLASS ORDER]
	Then I select 2017-12-14 22:51 on [DATETIMEPICKER|END DATE TIME] on [PAGE|CLASS ORDER]
	Then I click [BUTTON|SEARCH] ON [PAGE|CLASS ORDER]
	Then I select PAID on [DROPDOWNLIST|STATUS] on [PAGE|CLASS ORDER]
	Then I click [BUTTON|SEARCH] ON [PAGE|CLASS ORDER]
	Then I select ALIPAY on [DROPDOWNLIST|PAYMENT METHOD] on [PAGE|CLASS ORDER]
	Then I click [BUTTON|SEARCH] ON [PAGE|CLASS ORDER]
	Then I select CLASS NUMBER on [TEXTBOX|KEYWORD TYPE] on [PAGE|CLASS ORDER]
	Then I click [BUTTON|SEARCH] ON [PAGE|CLASS ORDER]
	Then I close the browser