using System;

namespace Payslip
{
    public class Calculator
    {
     
        private const int Month = 12;
        
        public Calculator()
        {
        }

        public static string GetFullName(string firstName, string surname)
        {
            return firstName + " " + surname;
        }

        public static string GetPayPeriod(string startDate, string endDate)
        {
            return startDate + " – " + endDate;
        }

        public static int GetGrossIncome(int annualSalary)
        {
            var result = annualSalary / Month;
            return annualSalary / Month;
        }

        public static int GetIncomeTax(int annualSalary)
        {
            var incomeTax = 0.0;
            switch (annualSalary)
            {
                case <= (int) TaxBrackets.Bracket1:
                    break;
                case <= (int) TaxBrackets.Bracket2:
                    incomeTax = 0.19 * (annualSalary - (int) TaxBrackets.Bracket1)/Month;
                    break;
                case <= (int) TaxBrackets.Bracket3:
                    incomeTax = (0.325 * (annualSalary - (int) TaxBrackets.Bracket2) + 3572)/Month;
                    break;
                case <= (int) TaxBrackets.Bracket4:
                    incomeTax = (0.37 * (annualSalary - (int) TaxBrackets.Bracket3) + 19822)/Month;
                    break;
                case >= (int) TaxBrackets.Bracket4:
                    incomeTax = (0.45 * (annualSalary - (int) TaxBrackets.Bracket4) + 54232)/Month;
                    break;
            }

            return (int) Math.Round(incomeTax, MidpointRounding.AwayFromZero);
        }

        public static int GetNetIncome(int grossIncome, int incomeTax)
        {
            return grossIncome - incomeTax;
        }

        public static int GetSuper(int grossIncome, int super)
        {
            return grossIncome * super / 100;
        }
        
    }
}