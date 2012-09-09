using System;
using System.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecSalad.features.Tasks
{
    public class SeeTheFavouriteColourIs : ApplicationTask
    {
        public override object Perform_Task()
        {
            var votes = (Table)Retrieve("whats your favourite colour");

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