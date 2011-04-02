using System.Linq;

namespace Calculator
{
    public class Operands
    {
        int?[] _operands = new int?[2];

        public int Size
        {
            get { return _operands.Count(item => item != null); }
        }

        public bool HasTwoOperands
        {
            get { return _operands[0] != null && _operands[1] != null; }
        }

        public int? this[int i]
        {
            set { _operands[i] = value; }
        }

        public void Push(int? value)
        {
            if (_operands[0] == null)
                _operands[0] = value;
            else
                _operands[1] = value;
        }

        public int? Inject(char? operand)
        {
            if (operand == '+')
                return _operands[0] + _operands[1];

            if (operand == '-')
                return _operands[0] - _operands[1];

            return null;
        }

        public void ClearAndSet(int value)
        {
            _operands = new int?[2];
            Push(value);
        }

        public void Concat(Operands operands)
        {
            Push(operands.Peek());
        }

        int? Peek()
        {
            if (_operands[1] != null)
                return _operands[1];

            return _operands[0];
        }
    }
}