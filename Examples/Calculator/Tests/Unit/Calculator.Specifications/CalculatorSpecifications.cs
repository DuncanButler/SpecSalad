using Machine.Specifications;

namespace Calculator.Tests.Unit
{
    [Subject("Calculator")]
    public class calculator_on_creation : CalculatorContext
    {
        It starts_with_a_0 =
            () => _calculator.Display.ShouldEqual(0);
    }

    [Subject("Calculator")]
    public class shows_the_current_number : CalculatorContext
    {
        Because of =
            () =>
            {
                _calculator.Enter(1);
            };

        It one_entered_displays_one =
            () => _calculator.Display.ShouldEqual(1);
    }

    [Subject("Calculator")]
    public class displays_the_same_when_equals_alone_is_pressed : CalculatorContext
    {
        Establish context =
            () =>
            {
                _calculator.Enter(1);
            };

        Because of =
            () =>
            {
                _calculator.Equals();
            };

        It one_entered_followed_by_a_single_equals_displays_one =
            () => _calculator.Display.ShouldEqual(1);
    }

    [Subject("Calculator")]
    public class treates_number_plus_equals_like_number_plus_number : CalculatorContext
    {
        Establish context =
            () =>
            {
                _calculator.Enter(1);
                _calculator.Get_Ready_To('+');
            };

        Because of =
            () =>
            {
                _calculator.Equals();
            };

        It one_entered_followed_by_a_plus_and_an_equals_displays_two =
            () => _calculator.Display.ShouldEqual(2);
    }

    [Subject("Calculator")]
    public class repeates_the_last_operation : CalculatorContext
    {
        Establish context =
            () =>
            {
                _calculator.Enter(1);
                _calculator.Get_Ready_To('+');
                _calculator.Equals();
            };

        Because of =
            () =>
            {
                _calculator.Equals();
            };

        It one_entered_followed_by_a_plus_and_equals_and_equals_displays_three =
            () => _calculator.Display.ShouldEqual(3);
    }

    [Subject("Calculator")]
    public class starts_again_when_you_enter_a_number_after_equals : CalculatorContext
    {
        Establish context =
            () =>
            {
                _calculator.Enter(1);
                _calculator.Get_Ready_To('+');
                _calculator.Enter(1);
                _calculator.Equals();
                _calculator.Enter(5);
                _calculator.Get_Ready_To('+');
            };

        Because of =
            () =>
            {
                _calculator.Equals();
            };

        It one_entered_followed_by_plus_and_one_and_equals_and_five_and_plus_and_equals_displays_ten =
            () => _calculator.Display.ShouldEqual(10);
    }

    [Subject("Calculator")]
    public class calculate_what_it_has_so_far : CalculatorContext
    {
        Establish context =
            () =>
            {
                _calculator.Enter(1);
                _calculator.Get_Ready_To('+');
                _calculator.Enter(1);
            };

        Because of =
            () =>
            {
                _calculator.Get_Ready_To('+');
            };

        It one_entered_followed_by_plus_and_one_and_plus_displays_two =
            () => _calculator.Display.ShouldEqual(2);
    }

    [Subject("Calculator")]
    public class calculate_adding_three_numbers : CalculatorContext
    {
        Establish context =
            () =>
            {
                _calculator.Enter(1);
                _calculator.Get_Ready_To('+');
                _calculator.Enter(1);
                _calculator.Get_Ready_To('+');
                _calculator.Enter(1);
            };

        Because of =
            () =>
            {
                _calculator.Equals();
            };

        It one_entered_and_plus_and_one_and_plus_and_one_and_equals_displays_three =
            () => _calculator.Display.ShouldEqual(3);
    }

    [Subject("Calculator")]
    public class calculate_adding_two_numbers : CalculatorContext
    {
        Establish context =
            () =>
            {
                _calculator.Enter(1);
                _calculator.Get_Ready_To('+');
                _calculator.Enter(1);
            };

        Because of =
            () =>
            {
                _calculator.Equals();
            };

        It one_entered_and_plus_and_one_and_equals_displays_two =
            () => _calculator.Display.ShouldEqual(2);
    }

    [Subject("Calculator")]
    public class calculate_subtraction_sums_with_single_number : CalculatorContext
    {
        Establish context =
            () =>
            {
                _calculator.Enter(-1);
                _calculator.Get_Ready_To('-');
            };

        Because of =
            () =>
            {
                _calculator.Equals();
            };

        It minus_one_entered_and_minus_and_equals_displays_zero =
            () => _calculator.Display.ShouldEqual(0);
    }

    [Subject("Calculator")]
    public class complex_calculations_even_numbered_inputs : CalculatorContext
    {
        Establish context =
            () =>
            {
                _calculator.Enter(10);
                _calculator.Get_Ready_To('+');
                _calculator.Enter(5);
                _calculator.Get_Ready_To('-');
                _calculator.Enter(3);
                _calculator.Get_Ready_To('-');
                _calculator.Enter(12);
            };

        Because of =
            () =>
            {
                _calculator.Equals();
            };

        It ten_entered_and_plus_five_and_minus_and_three_displays_twelve =
            () => _calculator.Display.ShouldEqual(0);
    }

    [Subject("Calculator")]
    public class complex_calculations_odd_numbered_inputs : CalculatorContext
    {
        Establish context =
            () =>
            {
                _calculator.Enter(10);
                _calculator.Get_Ready_To('+');
                _calculator.Enter(5);
                _calculator.Get_Ready_To('-');
                _calculator.Enter(3);
            };

        Because of =
            () =>
            {
                _calculator.Equals();
            };

        It ten_entered_and_plus_and_five_and_minus_and_three_displays_twelve =
            () => _calculator.Display.ShouldEqual(12);
    }

    public class CalculatorContext
    {
        Establish context =
            () =>
                {
                    _calculator = new TheCalculator();
                };

        protected static TheCalculator _calculator;
    }
}