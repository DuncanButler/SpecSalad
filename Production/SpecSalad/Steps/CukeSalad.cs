using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            var key = (from k in ScenarioContext.Current.Keys where k == name select k).FirstOrDefault();

            if(key==null)
                throw new SpecFlowException(string.Format("Role {0} not defined in scenario context",name));

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

        [Given(@"the ([a-zA-Z ]+) (?:attempts to|was able to|were able to|did)? ([A-Z a-z_-]*)(?:[:|,] (.*))?")]
        public void GivenTheRolePerformsATask(string role, string task, string details)
        {
            GetActor(role).Perform(task, details);    
        }

        [Given(@"(?:I|you) see a list ([A-Z a-z_-]*)?")]
        public void GivenThereIsAList(string name, Table theList)
        {            
            ScenarioContext.Current.Add(name, theList);
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

		[Then(@"(?:I|you) (?:can|am able to|are able to)? ([A-Z a-z_-]*)(?:[:|,] (.*))?")]
		public void ThenTaskSpecification(string task, string details)
		{
			GetActor("__Primary__").Perform(task, details);
		}

		[Then(@"the ([a-zA-Z ]+) (?:can|is able to)? ([A-Z a-z_-]*)(?:[:|,] (.*))?")]
		public void ThenTaskSpecificationWithSecondaryRole(string role, string task, string details)
		{
			GetActor(role).Perform(task, details);
		}

        [Then(@"(?:I|you) should ([^':]*) '([^']*)'")]
        public void ThenAreEqualSpecification(string theQuestion, string expectedAnswer)
        {
            string actualAnswer = Convert.ToString(GetActor("__Primary__").Answer(theQuestion));

            Assert.AreEqual(expectedAnswer, actualAnswer);
        }

        [Then(@"(?:I|you) should see ([^':]+) in the list?")]
        public void ThenAreInList(string theQuestion, Table expectedAnswers)
        {
            var actualAnswers = (Table) GetActor("__Primary__").Answer(theQuestion);

            Assert.That(actualAnswers.RowCount,Is.EqualTo(expectedAnswers.RowCount), "row counts do not match");

            bool equal = actualAnswers.Equals(expectedAnswers);

            var expectedValues = new List<string>();

            foreach (TableRow row in expectedAnswers.Rows)
            {
                var builder = new StringBuilder();
                foreach (var key in row.Keys)
                {
                    builder.Append(row[key]);
                    builder.Append(",");
                }

                expectedValues.Add(builder.ToString());
            }

            foreach (TableRow row in actualAnswers.Rows)
            {
                var builder = new StringBuilder();
                foreach (var key in row.Keys)
                {
                    builder.Append(row[key]);
                    builder.Append(",");
                }

                string found = (from v in expectedValues where v == builder.ToString() select v).FirstOrDefault();

                Assert.That(found,Is.Not.Null,"values not found in expected table");
            }                  
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