using Payslip.Interfaces;

namespace Payslip.Tests
{
    public class MockGetInput : IReadInput
    {
       
        public string? GetString()
        {
            return "500";
        }
        
    }
}