using System;
using SpecSalad;

namespace DummyTemplate.Tasks
{
    public class SwitchOnTheCalculator : ApplicationTask
    {
        public override object Perform_Task()
        {
            Role.switch_on_calculator();

            return null;
        }
    }
}