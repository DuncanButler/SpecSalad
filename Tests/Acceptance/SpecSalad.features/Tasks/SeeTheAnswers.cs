using System;

namespace SpecSalad.features.Tasks
{
    public class SeeTheAnswers : ApplicationTask
    {
        public override object Perform_Task()
        {
            return Role.GetTheAnswers();
        }
    }
}