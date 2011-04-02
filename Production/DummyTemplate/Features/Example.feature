Feature: Addition
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Add two numbers
	Given I am a Math Idiot
	And I was able to switch on the calculator
	When I attempt to add: the number '1' to the number '2'
	Then I should see the answer '3'
