using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace SpecSalad.features.Roles
{
    public class SecondaryRole : ApplicationRole
    {
        public bool Add(int theValue)
        {
            int total = (int) this.Retrieve("Total");

            total += 2;

            this.StoreValue("Total",total);

            return true;
        }

         public void SubtractOne()
         {
             int total = (int)this.Retrieve("Total");

             total -= 1;

             this.StoreValue("Total",total);
         }

        public int GetTheAnswer()
        {
            return (int) this.Retrieve("Total");
        }

        public void ShouldContainOne()
        {
            Assert.That(this.Retrieve("Total"),Is.EqualTo(1));
        }

        public ICollection GetTheAnswers()
        {
            var list = new List<string>();
            list.Add(this.Retrieve("Total").ToString());

            return list;
        }

    }
}