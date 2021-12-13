using Payslip.Interfaces;

namespace Payslip.Tests
{
    public class MockReadConsoleInput : IConsoleInput
    {
        public string ReadName()
        {
            return "John";
        }

        public int ReadNumber()
        {
            return 500;
        }

        public string ReadDate()
        {
            return "01 March";
        }
    }
}