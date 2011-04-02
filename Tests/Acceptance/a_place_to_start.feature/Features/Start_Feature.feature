Feature: A Place To Start
	As Colin. a conscientious cuker
	I want to write Cucumber features without step definitions
	So that I don't have to focus on writing regular expressions.
	and save time maintaining large step defination files
	and spend even more time delivering valuable fetures to my stakeholders

Scenario: Getting some guidance about an undefined role
	Given I am a Conscientious Cuker
	And I am using Cuke Salad
	When I write a simple feture like this:
	"""
	Feature: No Step Defs
		Scenario: Step free access
			Given I am a Step Free Cuker
			When I attempt to do an important thing
			Then I should see an equally important answer
	"""
	And I run 'cucumber'
	Then I should be told to define the 'Step Free Cuker' role

Scenario: Getting some guidance about an undefined task
	Given I am a Conscientious Cuker
	And I am using Cuke Salad
	When I write a sample feature like this:
	"""
	Feature: No Step Defs
		Scenario: Step free access
			Given I am a Step Free Cuker
			When I attempt to do an important thing
			Then I should see an equally important answer
	"""
	And I define a role like this:
	"""
	class StepFreeCuker : role
	{
	}
	"""
	And I run 'cucumber'
	Then I should be told to define the 'DoAnImportantThing' task

Scenario: Getting some guidance about an unknown question
	Given I am a Conscientious Cuker
	And I am using Cuke Salad
	When I write a simple feature like this
	"""
	Feature: No Step Defs
		Scenario: Step free access
			Given I am a Step Free Cuker
			When I attempt to do an important thing
			Then I should see an equally important answer
	"""
	And I define a role like this:
	"""
	class StepFreeCuker : role
	{
		public void do_the_thing()
		{
		}
	}
	"""
	And I define a task like this:
	"""
	class StepFreeTask : task
	{
		in_order_to("DoAnImprtentThing")
		{
			do_the_thing()
		}
	}
	"""
	And I run 'cucumber'
	Then I should be told to define the 'SeeAnImportantAnswer' task
