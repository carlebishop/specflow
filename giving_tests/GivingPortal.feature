Feature: GivingPortal

Scenario: Select Campus
	Given I am on the portal page
	When I select the East campus
	Then the East campus giving page should be displayed
