using System;

namespace SpecSalad.features.Tasks
{
    public class DoTheReturnOneTask : ApplicationTask
    {
        public override object Perform_Task()
        {
            return Role.SetTheAnswerTo(1);
        }
    }
}