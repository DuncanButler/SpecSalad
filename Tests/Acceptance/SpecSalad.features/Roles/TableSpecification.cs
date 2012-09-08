using System;
using System.Globalization;
using TechTalk.SpecFlow;

namespace SpecSalad.features.Roles
{
    public class TableSpecification : ApplicationRole
    {
         public void UpVoteAnswer(string answer)
         {
             var currentVoting = (Table) Retrieve("of answers to the question Whats your favorite colour");

             foreach (TableRow row in currentVoting.Rows)
             {
                 if (row["answer"] == answer)
                 {
                     int voteCount = Convert.ToInt32(row["vote"]);
                     voteCount++;

                     row["vote"] = voteCount.ToString(CultureInfo.InvariantCulture);
                 }
             }

             StoreValue("of answers to the question Whats your favorite colour", currentVoting);
         }
    }
}