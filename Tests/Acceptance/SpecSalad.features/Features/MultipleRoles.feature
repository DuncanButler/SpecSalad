Feature: Multiple Roles Within a Scenario
	I want to write Cucumber features without step definitions
	So that I don't have to focus on writing regular expressions.
	and save time maintaining large step defination files
	and spend even more time delivering valuable fetures to my stakeholders

	I should be able to define scenarios with multiple roles, to enable me to
	define the specifications of a project easily.

Scenario: Defining two roles the first is primary and used as defaut
	Given I am a specified role
	And there is a secondary role
	When I attempt to do the return one task
	Then I should see the answer '1'

Scenario: Defining two roles, actions interplay and results from primary
	Given I am a specified role
	And there is a secondary role
	When I attempt to do the return one task
	And the secondary role attempts to do the subtract one task
	Then I should see the answer '0'

Scenario: Defining two roles, which share the same action in different ways
	Given I am a specified role
	And there is a secondary role
	When I attempt to do the return one task
	And the secondary role attempts to do the return one task
	Then I should see the answer '3'

Scenario: Defining two roles, getting an equal answer from the second role
	Given I am a specified role
	And there is a secondary role
	When I attempt to do the return one task
	Then the secondary role should see the answer '1'

Scenario: Defining two roles, with a question from the secondary role
	Given I am a specified role
	And there is a secondary role
	When I attempt to do the return one task
	Then the secondary role should see one

Scenario: Defining two roles with a question that includes the answer from the secondary role
	Given I am a specified role
	And there is a secondary role
	When I attempt to do the return one task
	Then the secondary role should see the answers that includes: 1

Scenario: Multiple roles in one scenario
	Given I am a specified role
	And there is a secondary role
	And there is a auxiliary role
	When the auxiliary role attempts to do the return one task
	And the secondary role attempts to do the return one task
	Then I should see the answer '3'

Scenario: Defining the role using the secondary role given 
	Given there is a secondary role
	When the secondary role attempts to do the return one task
	Then the secondary role should see the answer '2'

Scenario: Defining the role but calling steps without role
	Given there is a secondary role
	When I attempt to do the return one task
	Then I should see the answer '2'

Scenario: Defining the secondary role with an action in the given
	Given I am a specified role
	And there is a secondary role
	And the secondary role attempts to do the return one task
	When the secondary role attempts to do the return one task
	Then the secondary role should see the answer '4'