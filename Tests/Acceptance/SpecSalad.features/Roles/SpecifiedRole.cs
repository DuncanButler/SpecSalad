using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace SpecSalad.features.Roles
{
    public class SpecifiedRole : ApplicationRole
    {
        int _theAnswer;

        public bool Add(int theValue)
        {
            _theAnswer += theValue;

            return true;
        }

        public int GetTheAnswer()
         {
             return _theAnswer;
         }

        public ICollection GetTheAnswers()
        {
            var list = new List<string>();
            list.Add(_theAnswer.ToString());

            return list;
        }

        public void ShouldContainOne()
        {
            Assert.AreEqual(1,_theAnswer);
        }
    }
}