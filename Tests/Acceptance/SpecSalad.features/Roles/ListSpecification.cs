using System;
using System.Globalization;
using TechTalk.SpecFlow;

namespace SpecSalad.features.Roles
{
    public class ListSpecification : ApplicationRole
    {
        public void UpVoteAnswer(string answer)
        {
            var currentVoting = (Table)Retrieve("whats your favourite colour");

            foreach (TableRow row in currentVoting.Rows)
            {
                if (row["answer"] == answer)
                {
                    int voteCount = Convert.ToInt32(row["vote"]);
                    voteCount++;

                    row["vote"] = voteCount.ToString(CultureInfo.InvariantCulture);
                }
            }

            StoreValue("whats your favourite colour", currentVoting);
        }
    }
}