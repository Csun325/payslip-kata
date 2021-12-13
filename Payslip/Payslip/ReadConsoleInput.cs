using System;
using System.Globalization;
using Payslip.Interfaces;

namespace Payslip
{
    public class ReadConsoleInput : IConsoleInput
    {
        private readonly IReadInput _input;
        
        public ReadConsoleInput(IReadInput input)
        {
            _input = input;
        }

        public string ReadName()
        {
            string? input = null;
            var condition = true;
            
            while (condition)
            {   
                input = _input.GetString();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please input a non-empty name");
                }
                else
                {
                    condition = false;
                }
            }

            return input!;
        }

        
        public int ReadNumber()
        {
            var numeric = 0;
            var condition = true;
            
            while (condition)
            {   
                var inputString = _input.GetString();
                var isNumeric = int.TryParse(inputString, out numeric);
                if (string.IsNullOrEmpty(inputString))
                {
                    Console.WriteLine("Please input a non-empty number");
                }
                else if (isNumeric == false)
                {
                    Console.WriteLine("Please input numbers only");
                }
                else
                {
                    condition = false;
                }
            }

            return numeric;
        }
        

        public string ReadDate()
        {
            var inputString = _input.GetString();
            DateTime dateTime;
            const string format = "d MMMM";
            if (DateTime.TryParseExact(inputString, format, CultureInfo.InvariantCulture, 
                DateTimeStyles.None, out dateTime))
            {
                return dateTime.ToString("dd MMMM");
                
            }
            else
            {
                throw new ArgumentException("Incorrect format, example = '1 March'");
            }
            
        }

    }
}