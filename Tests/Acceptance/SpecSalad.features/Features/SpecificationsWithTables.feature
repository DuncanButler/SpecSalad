Feature: specifications that contain tables
	in order to improve specificatons
	I want to be able to use tables within the specifications
	

Scenario: a simple table in the given statement
	Given I am a table specification
	And I see a list of answers to the question Whats your favorite colour
		| answer         | vote |
		| Red            | 1    |
		| Cucumber green | 1    |
		| blue           | 1    |
	When I attempt to upvote the answer, Cucumber green
	Then I should see the favorite colour is the answer 'Cucumber green'

Scenario: a simple table in the then statement
	Given I am a table specification
	And I see a list of answers to the question Whats your favorite colour
		| answer         | vote |
		| Red            | 1    |
		| Cucumber green | 1    |
		| blue           | 1    |
	When I attempt to upvote the answer, Cucumber green
	And  I attempt to upvote the answer, blue
	Then I should see the favorite colours in the list
		| answer         | vote |
		| Cucumber green | 2    |
		| blue           | 2    |
