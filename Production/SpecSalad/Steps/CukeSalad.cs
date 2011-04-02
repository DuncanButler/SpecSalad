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
        Actor _actor;

        [Given(@"I am a (.*)")]
        public void Given_I_am_a(string role)
        {
            Director director = new SaladDirector();

            _actor = new Actor(role, director);
        }

        [Given(@"I (?:attempt to|was able to)? ([A-Z a-z_-]*)(?:: (.*))?")]
        public void Given_I_was_able_to(string task, string details)
        {
            _actor.Perform(task, details);
        }

        [When(@"I (?:attempt to|was able to)? ([A-Z a-z_-]*)(?:: (.*))?")]
        public void When_I_attempt_to(string task, string details)
        {
            _actor.Perform(task, details);
        }

        [Then(@"I see text containing ([^']*) '([^']*)'")]
        public void Then_I_should_containing(string question, string expected)
        {
            IEnumerable<String> actual = (IEnumerable<string>) _actor.Answer(question);


            Assert.Contains(expected, (ICollection) actual);
        }

        [Then(@"I should ([^']*) '([^']*)'")]
        public void Then_I_should(string question, string expected)
        {
            string actual = Convert.ToString(_actor.Answer(question));

            Assert.AreEqual(expected, actual);
        }
    }
}
