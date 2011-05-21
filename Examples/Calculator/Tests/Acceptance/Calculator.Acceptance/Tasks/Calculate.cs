using System;
using SpecSalad;

namespace Calculator.Tasks
{
    public class Calculate : ApplicationTask
    {
        public override object Perform_Task()
        {
            var sum = Details.Value_Of("with_the_following");

            var items = sum.Split(' ');

            foreach (var item in items)
            {
                int num;
                if (int.TryParse(item, out num))
                {
                    Role.Enter(num);
                }
                else
                {
                    Role.Press(Convert.ToChar(item));
                }
            }

            return null;
        }
    }
}