Feature: Role storing values
	As Colin. a conscientious cuker
	I want to write Cucumber features without step definitions
	So that I don't have to focus on writing regular expressions.
	and save time maintaining large step defination files
	and spend even more time delivering valuable fetures to my stakeholders

	The role I define should be able ot save selected values defined in the 
	scenario text

Scenario: Save a value
	Given I am a specified role
	When I attempt to store: the value '3'
	Then I should retrieve the answer '3'
