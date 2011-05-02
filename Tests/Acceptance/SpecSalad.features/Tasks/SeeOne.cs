using System;

namespace SpecSalad.features.Tasks
{
    public class SeeOne : ApplicationTask
    {
        public override object Perform_Task()
        {
            Role.ShouldContainOne();

            return null;
        }
    }
}