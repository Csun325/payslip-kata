using System;
using Payslip.Interfaces;

namespace Payslip
{
    public class Employee
    {
        public string firstName;
        public string surname;
        public int annualSalary;
        public int super;
        public string startDate;
        public string endDate;

        public string fullname;
        public string payPeriod;
        public int grossIncome;
        public int incomeTax;
        public int netIncome;
        public int superCalc;

        private readonly IConsoleInput _consoleInput;
        private readonly Calculator _calculator;

        public Employee(IConsoleInput consoleInput, Calculator calc)
        {
            _consoleInput = consoleInput;
            _calculator = calc;
        }

        public void GenerateInput()
        {
            Console.Write("\nPlease input your name: ");
            firstName = _consoleInput.ReadName();
            Console.Write("Please input your surname: ");
            surname = _consoleInput.ReadName();
            Console.Write("Please enter your annual salary: ");
            annualSalary = _consoleInput.ReadNumber();
            Console.Write("Please enter your super rate: ");
            super = _consoleInput.ReadNumber();
            Console.Write("Please enter your payment start date: ");
            startDate = _consoleInput.ReadDate();
            Console.Write("Please enter your payment end date: ");
            endDate = _consoleInput.ReadDate();
        }

        public void CalculatePayslip()
        {
            fullname = Calculator.GetFullName(firstName, surname);
            payPeriod = Calculator.GetPayPeriod(startDate, endDate);
            grossIncome = Calculator.GetGrossIncome(annualSalary);
            incomeTax = Calculator.GetIncomeTax(annualSalary);
            netIncome = Calculator.GetNetIncome(grossIncome, incomeTax);
            superCalc = Calculator.GetSuper(grossIncome, super);
            
            Console.WriteLine("\nYour payslip has been generated: \n");
        }
    }
}