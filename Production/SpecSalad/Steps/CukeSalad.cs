using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
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

        [Given(@"(?:I am|you are) a ([a-zA-Z ]+)")]
        public void GivenRoleSpecification(string role)
        {
            Director director = new SaladDirector();

            TheActor = new Actor(role, director);
        }

        [Given(@"(?:I|you) (?:attempt to|was able to|were able to|did)? ([A-Z a-z_-]*)(?:: (.*))?")]
        public void GivenTaskSpecification(string task, string details)
        {
            TheActor.Perform(task, details);
        }

        [When(@"(?:I|you) (?:attempt to|was able to|were able to|did)? ([A-Z a-z_-]*)(?:: (.*))?")]
        public void WhenTaskSpecification(string task, string details)
        {
            TheActor.Perform(task, details);
        }

        [Then(@"(?:I|you) should ([^':]*) '([^']*)'")]
        public void ThenAreEqualSpecification(string theQuestion, string expectedAnswer)
        {
            string actualAnswer = Convert.ToString(TheActor.Answer(theQuestion));

            Assert.AreEqual(expectedAnswer, actualAnswer);
        }

        [Then(@"(?:I|you) should ([^':]+)")]
        public void ThenAnswerQuestion(string theQuestion)
        {
            TheActor.Answer(theQuestion);
        }

        [Then(@"(?:I|you) should ([^']*) that includes: (.*)")]
        public void ThenQuestionIncludes(string theQuestion, string expectedContent)
        {
            Assert.Contains(expectedContent,(ICollection) TheActor.Answer(theQuestion));
        }
    }
}