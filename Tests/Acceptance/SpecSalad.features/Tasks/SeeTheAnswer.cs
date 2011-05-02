using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecSalad.features.Tasks
{
    public class SeeTheAnswer : ApplicationTask
    {
        public override object Perform_Task()
        {
            return Role.GetTheAnswer();
        }
    }
}
