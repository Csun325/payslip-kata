using Payslip.Interfaces;

namespace Payslip
{
    public class Factory
    {
        private static GetInput CreateGetInput()
        {
            return new GetInput();
        }

        public static IConsoleInput CreateConsoleInput()
        {
            return new ReadConsoleInput(CreateGetInput());
        }
    }
}