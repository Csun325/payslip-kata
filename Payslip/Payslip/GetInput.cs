using System;
using Payslip.Interfaces;

namespace Payslip
{
    public class GetInput : IReadInput
    {
        public GetInput(){}
        public string? GetString()
        {
            var result = Console.ReadLine();
            return result;
        }
        
    }
}