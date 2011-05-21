using SpecSalad;

namespace Calculator.Tasks
{
    public class Subtract : ApplicationTask
    {
        public override object Perform_Task()
        {
            Role.Enter(int.Parse(Details.Value_Of("from_the_number")));
            Role.Press('-');
            Role.Enter(int.Parse(Details.Value_Of("the_number")));
            Role.Press('=');

            return null;
        }
    }
}