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
            Console.WriteLine("Please input your name: ");
            firstName = _consoleInput.ReadName();
            Console.WriteLine("Please input your surname: ");
            surname = _consoleInput.ReadName();
            Console.WriteLine("Please enter your annual salary: ");
            annualSalary = _consoleInput.ReadNumber();
            Console.WriteLine("Please enter your super rate: ");
            super = _consoleInput.ReadNumber();
            Console.WriteLine("Please enter your payment start date: ");
            startDate = _consoleInput.ReadDate();
            Console.WriteLine("Please enter your payment end date: ");
            endDate = _consoleInput.ReadDate();
        }

        public void CalculatePayslip()
        {
            fullname = _calculator.GetFullName(firstName, surname);
            payPeriod = _calculator.GetPayPeriod(startDate, endDate);
            grossIncome = _calculator.GetGrossIncome(annualSalary);
            incomeTax = _calculator.GetIncomeTax(annualSalary);
            netIncome = _calculator.GetNetIncome(grossIncome, incomeTax);
            superCalc = _calculator.GetSuper(grossIncome, super);
        }
    }
}