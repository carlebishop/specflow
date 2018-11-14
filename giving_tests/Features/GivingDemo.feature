Feature: Giving Demo
	In order to show how giving automation could work
	As a test developer
	I want to show this demo

@Demoscenarios
Scenario: Display Dashboard Page
	Given I am on the login page
	And I have entered my login information
	When I press login
	Then I should be on the dashboard screen

Scenario: Failed login
	Given I am on the login page
	And I have entered "badlogin@badlxxxogin.com" for a userid
	When I press login
	Then I should get a failed login message