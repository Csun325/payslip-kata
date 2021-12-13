using Payslip.Interfaces;

namespace Payslip
{
    public class Factory
    {
        private static GetInput CreateGetInput()
        {
            return new GetInput();
        }

        private static IConsoleInput CreateConsoleInput()
        {
            return new ReadConsoleInput(CreateGetInput());
        }

        private static Calculator CreateCalculator()
        {
            return new Calculator();
        }

        public static Employee CreateEmployee()
        {
            return new Employee(CreateConsoleInput(), CreateCalculator());
        }

        public static PrintConsoleOutput CreateConsoleOutput(Employee employee)
        {
            return new PrintConsoleOutput(employee);
        }
    }
}