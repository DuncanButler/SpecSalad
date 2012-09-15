Feature: When Syntax Options
	As Colin. a conscientious cuker
	I want to write Cucumber features without step definitions
	So that I don't have to focus on writing regular expressions.
	and save time maintaining large step defination files
	and spend even more time delivering valuable fetures to my stakeholders

	The tasks I define should link correctly to the specified role and be able to 
	define a required result

Scenario: calling when with the syntax I attempt to
	Given I am a specified role
	When I attempt to do the return one task
	Then I should see the answer '1'

Scenario: calling when with the syntax I was able to
	Given I am a specified role
	When I was able to do the return one task
	Then I should see the answer '1'

Scenario: calling when with the syntax I were able to
	Given I am a specified role
	When I were able to do the return one task
	Then I should see the answer '1'

Scenario: calling when with the syntax I did
	Given I am a specified role
	When I did the return one task
	Then I should see the answer '1'

Scenario: calling when with the syntax you attempt to
	Given I am a specified role
	When you attempt to do the return one task
	Then I should see the answer '1'
	
Scenario: calling when with the syntax you were able to
	Given I am a specified role
	When you were able to do the return one task
	Then I should see the answer '1'

Scenario: calling when with the syntax you did
	Given I am a specified role
	When you did the return one task
	Then I should see the answer '1'

Scenario: calling when with one parameter
	Given I am a specified role
	When I attempt to do the return task: with a single parameter '2'
	Then I should see the answer '2'

Scenario: calling when with the syntax I attempt to with multiple parameters
	Given I am a specified role
	When I attempt to do the return task: with parameter '2' and parameter '3' 
	Then I should see the answer '5'

Scenario: calling when with the syntax containing a comma instead of a colon
	Given I am a specified role
	When I attempt to do the return task, with parameter '2' and parameter '1'
	Then I should see the answer '3'

Scenario: using when with a do syntax
	Given I am a specified role
	When I do the return task, with parameter '2' and parameter '1'
	Then I should see the answer '3'

Scenario: using when does syntax when there are multiple rows
	Given I am a specified role
	And there is a secondary role
	And the secondary role attempts to do the return one task
	When the secondary role does the return one task
	Then the secondary role should see the answer '4'
