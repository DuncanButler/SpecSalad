Feature: Background step defination usage
	In to make my features easier to read
	As a developer
	I want to be able to use the background tag

Background: 
	Given I am a specified role
	And I attempt to do the return one task

Scenario: Add one to the number	
	When I attempt to do the return one task
	Then I should see the answer '2'

Scenario: Each scenario is independent of the others
	When I attempt to do the return one task
	Then I should see the answer '2'
	