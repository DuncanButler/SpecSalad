Feature: Then Syntax Options
	As Colin. a conscientious cuker
	I want to write Cucumber features without step definitions
	So that I don't have to focus on writing regular expressions.
	and save time maintaining large step defination files
	and spend even more time delivering valuable fetures to my stakeholders

	The tasks I define should link correctly to the specified role and be able to 
	define a required result.

Scenario: calling then with the syntax I should <question> <answer>
	Given I am a specified role
	When I attempt to do the return one task
	Then I should see the answer '1'

Scenario: calling then with the syntax you should <question> <answer>
	Given I am a specified role
	When I attempt to do the return one task
	Then you should see the answer '1'

Scenario: calling then with the syntax I should <question>
	Given I am a specified role
	When I attempt to do the return one task
	Then I should see one

Scenario: calling then with the syntax you should <question>
	Given I am a specified role
	When I attempt to do the return one task
	Then you should see one

Scenario: calling then with the syntax I should <question> that includes <expected content>
	Given I am a specified role
	When I attempt to do the return one task
	Then I should see the answers that includes: 1

Scenario: calling then with syntax I can <task>
	Given I am a specified role
	When I attempt to do the return one task
	Then I can get the answer: 1

Scenario: calling then with syntax I am able to <task>
	Given I am a specified role
	When I attempt to do the return one task
	Then I am able to get the answer: 1

Scenario: calling then with syntax you can <task>
	Given I am a specified role
	When I attempt to do the return one task
	Then I can get the answer: 1

Scenario: calling then with syntax you are able to <task>
	Given I am a specified role
	When I attempt to do the return one task
	Then I am able to get the answer: 1


