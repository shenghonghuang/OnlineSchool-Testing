Feature: Course Orders
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@ViewCourseOrders
Scenario: View Course Orders
	Given I am in home page
	Then I click LINK of LOGIN
	Then I fill administrator account in [TEXTBOX|USERNAME], [TEXTBOX|PASSWORD] and click [BUTTON|LOGIN] on [PAGE|LOGIN]
	Then I move mouse on the avatar
	Then I click [MENU|MANAGEMENT] ON [PAGE|HOME]
	Then I click [MENU|ORDER] ON [PAGE|MANAGEMENT]
	Then I click [MENU|COURSE ORDER] ON [MENU|ORDER]
	Then I click [BUTTON|SEARCH] ON [PAGE|COURSE ORDER]
	Then I select 2017-12-14 22:51 on [DATETIMEPICKER|START DATE TIME] on [PAGE|COURSE ORDER]
	Then I click [BUTTON|SEARCH] ON [PAGE|COURSE ORDER]
	Then I select 2017-12-14 22:51 on [DATETIMEPICKER|END DATE TIME] on [PAGE|COURSE ORDER]
	Then I click [BUTTON|SEARCH] ON [PAGE|COURSE ORDER]
	Then I select PAID on [DROPDOWNLIST|STATUS] on [PAGE|COURSE ORDER]
	Then I click [BUTTON|SEARCH] ON [PAGE|COURSE ORDER]
	Then I select ALIPAY on [DROPDOWNLIST|PAYMENT METHOD] on [PAGE|COURSE ORDER]
	Then I click [BUTTON|SEARCH] ON [PAGE|COURSE ORDER]
	Then I select COURSE NAME on [TEXTBOX|KEYWORD TYPE] on [PAGE|COURSE ORDER]
	Then I click [BUTTON|SEARCH] ON [PAGE|COURSE ORDER]
	Then I close the browser