using System;
using TechTalk.SpecFlow;

namespace SpecSalad.features.Tasks
{
    public class AvailableColours : ApplicationTask
    {
        public override object Perform_Task()
        {
            return (Table)this.Role.Retrieve("available colours");
        }
    }
}