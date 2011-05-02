using System;

namespace SpecSalad.features.Tasks
{
    public class DoTheReturnTask : ApplicationTask
    {
        public override object Perform_Task()
        {
            if (string.IsNullOrEmpty(Details.Value_Of("with_a_single_parameter")))
            {
                Role.SetTheAnswerTo(Convert.ToInt32(Details.Value_Of("with_parameter")));
                Role.SetTheAnswerTo(Convert.ToInt32(Details.Value_Of("and_parameter")));
            }
            else
            {
                Role.SetTheAnswerTo(Convert.ToInt32(Details.Value_Of("with_a_single_parameter")));                
            }

            return true;
        }
    }
}