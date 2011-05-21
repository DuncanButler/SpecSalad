using SpecSalad;

namespace Calculator.Roles
{
    public class CalculatingIndividual : ApplicationRole
    {
        TheCalculator _calculator;

        public TheCalculator SwitchOnCalculator()
        {
            _calculator = new TheCalculator();

            return _calculator;
        }

        public void Enter(int value)
        {
            _calculator.Enter(value);
        }

        public void Press(char function)
        {
            if (function == '=')
                _calculator.Equals();
            else
                _calculator.Get_Ready_To(function);
        }

        public int LookAtTheDisplay()
        {
            return _calculator.Display;
        }
    }
}