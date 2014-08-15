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

Scenario: calling given with the syntax I am an
	Given I am an extra role
	When I attempt to do the return one task
	Then I should see the answer '1'

Scenario: calling given with the syntax you are a
	Given you are a specified role
	When I attempt to do the return one task
	Then I should see the answer '1'

Scenario: calling given with the syntax you are an
	Given you are an extra role
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

Scenario: calling given and with the syntax including a comma instead of the colon
	Given I am a specified role
	And I did the return task, with a single parameter '2'
	When I attempt to do the return task: with a single parameter '1'
	Then I should see the answer '3'

Scenario: using the given does syntax with multiple roles
	Given I am a specified role
	And there is a secondary role
	And the secondary role does the return one task
	When the secondary role does the return one task
	Then the secondary role should see the answer '4'

Scenario: using the given does syntax with multiple roles using an
	Given I am a specified role
	And there is an extra secondary role
	And the extra secondary role does the return one task
	When the extra secondary role does the return one task
	Then the extra secondary role should see the answer '4'