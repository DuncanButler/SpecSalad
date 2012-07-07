Feature: Task storing values
	As Colin. a conscientious cuker
	I want to write Cucumber features without step definitions
	So that I don't have to focus on writing regular expressions.
	and save time maintaining large step defination files
	and spend even more time delivering valuable fetures to my stakeholders

	The task I define should be able to store its values in the scenario context,
	so that the role can use the values during a later scenario step

Scenario: Save a value
	Given I am a specified role
	When I attempt to store in the task: the value '3'
	Then I should be able to retrieve the answer '3'
