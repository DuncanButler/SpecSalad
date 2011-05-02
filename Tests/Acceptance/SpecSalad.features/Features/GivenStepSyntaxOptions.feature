Feature: Given Syntax Options
	As Colin. a conscientious cuker
	I want to write Cucumber features without step definitions
	So that I don't have to focus on writing regular expressions.
	and save time maintaining large step defination files
	and spend even more time delivering valuable fetures to my stakeholders

	The tasks I define should link correctly to the specified role and be able to 
	define a required result.

Scenario: calling given with the syntax I am a
	Given I am a specified role
	When I attempt to do the return one task
	Then I should see the answer '1'

Scenario: calling given with the syntax you are a
	Given you are a specified role
	When I attempt to do the return one task
	Then I should see the answer '1'

Scenario: calling given and with the syntax I attempt to
	Given I am a specified role
	And I attempt to do the return task: with a single parameter '2'
	When I attempt to do the return task: with a single parameter '2'
	Then I should see the answer '4'

Scenario: calling given and with the syntax I was able to
	Given I am a specified role
	And I was able to do the return task: with a single parameter '2'
	When I attempt to do the return task: with a single parameter '2'	
	Then I should see the answer '4'

Scenario: calling given and with the syntax I were able to
	Given I am a specified role
	And I were able to do the return task: with a single parameter '2'
	When I attempt to do the return task: with a single parameter '2'	
	Then I should see the answer '4'

Scenario: calling given and with the syntax I did
	Given I am a specified role
	And I did the return task: with a single parameter '2'
	When I attempt to do the return task: with a single parameter '2'	
	Then I should see the answer '4'
