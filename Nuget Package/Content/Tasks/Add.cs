using System;
using SpecSalad;

namespace DummyTemplate.Tasks
{
    public class Add : ApplicationTask
    {
        public override object Perform_Task()
        {
            Role.enter(int.Parse(Details.Value_Of("the_number")));
            Role.press('+');
            Role.enter(int.Parse(Details.Value_Of("to_the_number")));
            Role.press('=');

            return null;
        }
    }
}