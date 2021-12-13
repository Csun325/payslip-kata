using System;

namespace Payslip
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the payslip generator!");

            var employee1 = Factory.CreateEmployee();
            employee1.GenerateInput();
            employee1.CalculatePayslip();
            var printOutput = Factory.CreateConsoleOutput(employee1);
            printOutput.PrintPayslipToConsole();
        }
    }
}

