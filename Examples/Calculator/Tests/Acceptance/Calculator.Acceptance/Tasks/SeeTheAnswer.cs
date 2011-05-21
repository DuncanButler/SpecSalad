using SpecSalad;

namespace Calculator.Tasks
{
    public class SeeTheAnswer : ApplicationTask
    {
        public override object Perform_Task()
        {
            return Role.LookAtTheDisplay();
        }
    }
}