Feature: specifications that contain tables
	in order to improve specificatons
	I want to be able to use tables within the specifications
	
Scenario: a simple table in the given statement
	Given I am a table specification
	And I can see the table whats your favourite colour
		| answer         | vote |
		| Red            | 1    |
		| Cucumber green | 1    |
		| blue           | 1    |
	When I attempt to up vote the answer, Cucumber green
	Then I should see the favourite colour is 'Cucumber green'

Scenario: a simple table in the then statement
	Given I am a table specification
	And I can see the table whats your favourite colour
		| answer         | vote |
		| Red            | 1    |
		| Cucumber green | 1    |
		| blue           | 1    |
	When I attempt to up vote the answer, Cucumber green
	And  I attempt to up vote the answer, blue
	Then I should see the favourite colours table
		| answer         | vote |
		| Cucumber green | 2    |
		| blue           | 2    |

Scenario: alternate syntax for the table statement
	Given I am a table specification
	And I can see the details whats your favourite colour
		| answer         | vote |
		| Red            | 1    |
		| Cucumber green | 1    |
		| blue           | 1    |
	When I attempt to up vote the answer, blue
	And I attempt to up vote the answer, Cucumber green
	Then I should see the favourite colours with details
		| answer         | vote |
		| Cucumber green | 2    |
		| blue           | 2    |
