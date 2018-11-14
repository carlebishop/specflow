Feature: G4
	In order to give donations
	As a church member
	I want a giving page

@g4givingscenarios
Scenario: Basic Giving Scenario
	Given I am on the THENCAMPUS giving page
	When I select MISSIONS from the fund drop down 
	And I enter 1.00 into the amount
	And I fill out the credit card information with a test card
	And I press submit
	Then I should see a successful transaction message
