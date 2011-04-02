using SpecSalad;

namespace Calculator.Tasks
{
    public class Subtract : ApplicationTask
    {
        public override object Perform_Task()
        {
            Role.enter(int.Parse(Details.Value_Of("from_the_number")));
            Role.press('-');
            Role.enter(int.Parse(Details.Value_Of("the_number")));
            Role.press('=');

            return null;
        }
    }
}