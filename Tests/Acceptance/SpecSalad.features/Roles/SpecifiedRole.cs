using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace SpecSalad.features.Roles
{
    public class SpecifiedRole : ApplicationRole
    {
        public SpecifiedRole()
        {
            TheAnswer = 0;
        }

        int TheAnswer 
        { 
            get
            {
                object result = this.Retrieve("Total");

                if (result == null)
                    return 0;

                return (int) result; 
            }
            set
            {
                this.StoreValue("Total",value);
            }
        }
       
        public bool Add(int theValue)
        {
            TheAnswer += theValue;

            return true;
        }

        public int GetTheAnswer()
         {
             return TheAnswer;
         }

        public ICollection GetTheAnswers()
        {
            var list = new List<string>();
            list.Add(TheAnswer.ToString());

            return list;
        }

        public void ShouldContainOne()
        {
            Assert.AreEqual(1,TheAnswer);
        }

        public object GetStoredTaskAnswer()
        {
            return  this.Retrieve("FromTask");
        }

		public void CheckTheAnswerIs(string answer)
		{
			Assert.That(answer, Is.EqualTo("1"));
		}
    }
}