Feature: Multiple Roles Within a Scenario
	I want to write Cucumber features without step definitions
	So that I don't have to focus on writing regular expressions.
	and save time maintaining large step defination files
	and spend even more time delivering valuable fetures to my stakeholders

	I should be able to define scenarios with multiple roles, to enable me to
	define the specifications of a project easily.

Scenario: Defining two roles the first is primary and used as defaut
	Given I am a specified role
	And There is a secondary role
	When I attempt to do the return one task
	Then I should see the answer '1'

Scenario: Defining two roles, actions interplay and results from primary
	Given I am a specified role
	And There is a secondary role
	When I attempt to do the return one task
	And The secondary role attempts to do the subtract one task
	Then I should see the answer '0'

Scenario: Defining two roles, which share the same action in different ways
	Given I am a specified role
	And There is a secondary role
	When I attempt to do the return one task
	And The secondary role attempts to do the return one task
	Then I should see the answer '3'

