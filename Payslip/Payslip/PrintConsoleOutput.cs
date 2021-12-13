using System;

namespace Payslip
{
    public class PrintConsoleOutput
    {
        private readonly Employee _employee;
        public PrintConsoleOutput(Employee employee)
        {
            _employee = employee;
        }

        public void PrintPayslipToConsole()
        {
            Console.WriteLine("Name: " + _employee.fullname);
            Console.WriteLine("Pay Period: " + _employee.payPeriod);
            Console.WriteLine("Gross Income: " + _employee.grossIncome);
            Console.WriteLine("Income Tax: " + _employee.incomeTax);
            Console.WriteLine("Net Income: " + _employee.netIncome);
            Console.WriteLine("Super: " + _employee.superCalc);
            
            Console.WriteLine("\nThank you for using MYOB!");
        }
    }
}