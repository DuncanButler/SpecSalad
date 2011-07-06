using System;
using System.Collections;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecSalad.Steps
{
    [Binding]
    public class CukeSalad
    {
        string Primary 
        { 
            get { return ScenarioContext.Current.Get<string>("__Primary__"); } 
            set
            {
                string toSet;
                ScenarioContext.Current.TryGetValue("__Primary__", out toSet);

                if(string.IsNullOrWhiteSpace(toSet))
                    ScenarioContext.Current.Set(value,"__Primary__");
            }
        }

        Actor GetActor(string name)
        {
            if (name.Equals("__Primary__"))
                return ScenarioContext.Current.Get<Actor>(Primary);

            return ScenarioContext.Current.Get<Actor>(name);
        }

        void SetActor(string name, Actor actor)
        {
            ScenarioContext.Current.Set(actor, name);
        }

        Director TheDirector
        {
            get
            {
                Director toReturn;
                ScenarioContext.Current.TryGetValue("Director", out toReturn);

                return toReturn;                
            }

            set{ ScenarioContext.Current.Set(value,"Director");}
        }

        [Given(@"(?:I am|you are) a ([a-zA-Z ]+)")]
        public void GivenRoleSpecification(string role)
        {
            TheDirector = new SaladDirector();
            Primary = role;
            SetActor(role,new Actor(role, TheDirector));            
        }

        [Given(@"(?:I|you) (?:attempt to|was able to|were able to|did)? ([A-Z a-z_-]*)(?:[:|,] (.*))?")]
        public void GivenTaskSpecification(string task, string details)
        {
            GetActor("__Primary__").Perform(task, details);
        }

        [Given(@"there is a ([a-zA-Z ]+)")]
        public void GivenAdditionalRoleSpecification(string role)
        {
            if(TheDirector == null)
                TheDirector = new SaladDirector();

            Primary = role;

            SetActor(role, new Actor(role,TheDirector));
        }

        [When(@"(?:I|you) (?:attempt to|was able to|were able to|did)? ([A-Z a-z_-]*)(?:[:|,] (.*))?")]
        public void WhenTaskSpecification(string task, string details)
        {
            GetActor("__Primary__").Perform(task, details);
        }

        [When(@"the ([a-zA-Z ]+) (?:attempts to|was able to|were able to|did)? ([A-Z a-z_-]*)(?:[:|,] (.*))?")]
        public void WhenTaskSpecificationWithSecondaryRole(string role, string task,string details)
        {
            GetActor(role).Perform(task,details);
        }

        [Then(@"(?:I|you) should ([^':]*) '([^']*)'")]
        public void ThenAreEqualSpecification(string theQuestion, string expectedAnswer)
        {
            string actualAnswer = Convert.ToString(GetActor("__Primary__").Answer(theQuestion));

            Assert.AreEqual(expectedAnswer, actualAnswer);
        }

        [Then(@"(?:I|you) should ([^':]+)")]
        public void ThenAnswerQuestion(string theQuestion)
        {
            GetActor("__Primary__").Answer(theQuestion);
        }

        [Then(@"(?:I|you) should ([^']*) that includes: (.*)")]
        public void ThenQuestionIncludes(string theQuestion, string expectedContent)
        {
            Assert.Contains(expectedContent, (ICollection)GetActor("__Primary__").Answer(theQuestion));
        }

        [Then(@"the ([a-zA-Z ]+) should ([^':]*) '([^']*)'")]
        public void ThenAreEqualSpecificationWithSecondaryRole(string role, string theQuestion, string expectedAnswer)
        {
            string actualAnswer = Convert.ToString(GetActor(role).Answer(theQuestion));

            Assert.AreEqual(expectedAnswer, actualAnswer);
        }

        [Then(@"the ([a-zA-Z ]+) should ([^':]+)")]
        public void ThenAnswerQuestionWithSecondaryRole(string role, string theQuestion)
        {
            GetActor(role).Answer(theQuestion);
        }

        [Then(@"the ([a-zA-Z ]+) should ([^']*) that includes: (.*)")]
        public void TheAnswerIncludesWithSecondaryRole(string role, string theQuestion, string expectedContent)
        {
            Assert.Contains(expectedContent, (ICollection)GetActor(role).Answer(theQuestion));
        }
    }
}