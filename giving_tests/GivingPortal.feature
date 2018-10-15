Feature: GivingPortal

Scenario: Select Campus
	Given I am on the portal page
	When I select the EAST campus
	Then the EAST campus giving page should be displayed

Scenario Outline: Go To Campus
Given I am on the portal page
When I select the <campus> campus
Then the <campus> campus giving page should be displayed

Examples:
| campus     |
| EAST       |
| MISSIONS   |
| ANOTHER    |
| NOWCAMPUS  |
| THENCAMPUS |
