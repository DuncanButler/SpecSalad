using SpecSalad;

namespace Calculator.Tasks
{
    public class SwitchOnTheCalculator : ApplicationTask
    {
        public override object Perform_Task()
        {
            Role.SwitchOnCalculator();
            
            return null;
        }
    }
}