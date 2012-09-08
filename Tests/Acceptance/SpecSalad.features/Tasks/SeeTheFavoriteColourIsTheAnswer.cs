using System;
using System.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecSalad.features.Tasks
{
    public class SeeTheFavoriteColourIsTheAnswer : ApplicationTask
    {
        public override object Perform_Task()
        {
            var votes = (Table) Retrieve("of answers to the question Whats your favorite colour");

            string winningColour = "";
            int[] winningVoteCount = {0};

            foreach (var row in votes.Rows.Where(row => Convert.ToInt32(row["vote"]) > winningVoteCount[0]))
            {
                winningColour = row["answer"];
                winningVoteCount[0] = Convert.ToInt32(row["vote"]);
            }

            return winningColour;
        }
    }
}