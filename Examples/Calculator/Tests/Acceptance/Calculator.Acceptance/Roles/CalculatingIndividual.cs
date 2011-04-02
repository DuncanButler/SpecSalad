using SpecSalad;

namespace Calculator.Roles
{
    public class CalculatingIndividual : ApplicationRole
    {
        TheCalculator _calculator;

        public TheCalculator switch_on_calculator()
        {
            _calculator = new TheCalculator();

            return _calculator;
        }

        public void enter(int value)
        {
            _calculator.Enter(value);
        }

        public void press(char function)
        {
            if(function == '=')
                _calculator.Equals();
            else
                _calculator.Get_Ready_To(function);
        }

        public int look_at_the_display()
        {
            return _calculator.Display;
        }
    }
}