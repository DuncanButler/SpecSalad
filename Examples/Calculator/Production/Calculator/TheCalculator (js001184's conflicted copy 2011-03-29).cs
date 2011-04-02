namespace Calculator
{
    public class TheCalculator
    {
        readonly Operands _operands;
        bool _lastFunctionWasEquals;
        char? _lastOperator;
        char? _operator;

        public TheCalculator()
        {
            _operands = new Operands();
            show(0);
        }

        public int Display { get; private set; }

        public void Enter(int value)
        {
            _lastFunctionWasEquals = false;

            show(value);
            _operands.Push(value);
        }

        public void Get_Ready_To(char function)
        {
            _lastFunctionWasEquals = false;

            calculate_if_neccessary();
            start_next_calculation();

            _operator = function;
        }

        public void Equals()
        {
            we_need_two_operands();
            deal_with_repeated_equals();

            if (_operator != null)
            {
                show((int) _operands.Inject(_operator));
                _lastOperator = _operator;
                _operator = null;
                _operands[0] = Display;
            }

            _lastFunctionWasEquals = true;
        }

        void show(int value)
        {
            Display = value;
        }

        void start_next_calculation()
        {
            if (_operator == null)
                _operands.ClearAndSet(Display);
        }

        void calculate_if_neccessary()
        {
            if (_operands.HasTwoOperands)
                Equals();
        }

        void we_need_two_operands()
        {
            if (_operands.Size == 1)
                _operands.Concat(_operands);
        }

        void deal_with_repeated_equals()
        {
            if (_operands.HasTwoOperands && _operator == null && _lastOperator != null && _lastFunctionWasEquals)
                _operator = _lastOperator;
        }
    }
}