Feature: BackgroundTagWithMultipleRoles
	In order to make my features easier to read
	As a developer
	I want to be able to use multiple roles with the background tag

Background: 
	Given there is a secondary role
	And the secondary role attempts to do the return one task
	And I am a specified role

Scenario: The first person pronoun should take precedence over the impersonal
	When I attempt to do the return one task
	Then I should see the answer '1'

Scenario: The secondary actor should still do their expected action
	When the secondary role attempts to do the return one task
	Then the secondary role should see the answer '2'
