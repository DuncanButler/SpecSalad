using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecSalad
{
    [Binding]
    public class CukeSalad
    {
        Actor TheActor
        {
            get { return ScenarioContext.Current.Get<Actor>(); }
            set { ScenarioContext.Current.Set(value); }
        }

        [Given(@"I am a (.*)")]
        public void Given_I_am_a(string role)
        {
            Director director = new SaladDirector();

            TheActor = new Actor(role, director);
        }

        [Given(@"I (?:attempt to|was able to)? ([A-Z a-z_-]*)(?:: (.*))?")]
        public void Given_I_was_able_to(string task, string details)
        {
            TheActor.Perform(task, details);
        }

        [When(@"I (?:attempt to|was able to)? ([A-Z a-z_-]*)(?:: (.*))?")]
        public void When_I_attempt_to(string task, string details)
        {
            TheActor.Perform(task, details);
        }

        [Then(@"I see text containing ([^']*) '([^']*)'")]
        public void Then_I_should_containing(string question, string expected)
        {
            var actual = (IEnumerable<string>) TheActor.Answer(question);

            Assert.Contains(expected, (ICollection) actual);
        }

        [Then("I shouldn't ([^']*) '([^']*)'")]
        public void Then_I_should_not(string question, string notExpected)
        {
            string actual = Convert.ToString(TheActor.Answer(question));

            Assert.AreNotEqual(notExpected, actual);
        }

        [Then(@"I should ([^']*) '([^']*)'")]
        public void Then_I_should_see(string question, string expected)
        {
            string actual = Convert.ToString(TheActor.Answer(question));

            Assert.AreEqual(expected, actual);
        }
    }
}