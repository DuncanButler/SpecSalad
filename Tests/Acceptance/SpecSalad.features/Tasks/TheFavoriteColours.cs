using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace SpecSalad.features.Tasks
{
    public class TheFavoriteColours : ApplicationTask
    {
        public override object Perform_Task()
        {
            var table = (Table) this.Retrieve("of answers to the question Whats your favorite colour");

            int maxCount = table.Rows.Select(row => Convert.ToInt32(row["vote"])).Concat(new[] {0}).Max();

            var result = new Table(table.Header.ToArray());

            foreach (var row in table.Rows.Where(row => Convert.ToInt32(row["vote"]) == maxCount))
            {
                result.AddRow(row);
            }

            return result;
        }
    }
}