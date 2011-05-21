using System;

namespace SpecSalad.features.Tasks
{
    public class DoTheReturnOneTask : ApplicationTask
    {
        public override object Perform_Task()
        {
            return Role.Add(1);
        }
    }
}