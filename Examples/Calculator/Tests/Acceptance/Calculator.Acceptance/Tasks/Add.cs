using SpecSalad;

namespace Calculator.Acceptance.Tasks
{
    public class Add : ApplicationTask
    {
        public override object Perform_Task()
        {
            Role.Enter(int.Parse(Details.Value_Of("the_number")));
            Role.Press('+');
            Role.Enter(int.Parse(Details.Value_Of("to_the_number")));
            Role.Press('=');

            return null;
        }
    }
}