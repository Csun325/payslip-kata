using Xunit;
using System;

namespace Payslip.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calc;

        public CalculatorTests()
        {
            _calc = new Calculator();
        }
        
        [Fact]
        public void GetFullName_WhenInputIsString_ReturnBothStringsWithSpace()
        {
            //arrange
            //action
            var result = Calculator.GetFullName("John", "Doe");
            //assert
            Assert.Equal("John Doe", result);
        }

        [Fact]
        public void GetPayPeriod_WhenInputIsValid_ReturnPeriodWithDashInBetween()
        {
            //action
            var result = Calculator.GetPayPeriod("01 March", "31 March");
            //assert
            Assert.Equal("01 March – 31 March", result);
        }

        [Fact]
        public void GetGrossIncome_WhenInputIsValid_ReturnCorrectIntOutput()
        {
            //action
            var result = Calculator.GetGrossIncome(60050);
            //assert
            Assert.Equal(5004, result);
        }

        
        [Theory]
        [InlineData(60050, 922)]
        [InlineData(190000,4894)]
        [InlineData(16000,0)]
        public void GetIncomeTax_WhenInputIsValid_ReturnCorrespondingTaxValue(
            int annualSalary, int tax)
        {
            //action
            var result = Calculator.GetIncomeTax(annualSalary);
            //assert
            Assert.Equal(tax,result);
        }


        [Fact]
        public void GetNetIncome_WhenInputIsValid_ReturnCorrectOutput()
        {
            //action
            var result = Calculator.GetNetIncome(5004, 922);
            //assert
            Assert.Equal(4082, result);
        }

        [Fact]
        public void GetSuper_WhenInputIsValid_ReturnCorrectOutput()
        {
            //action
            var result = Calculator.GetSuper(5004, 9);
            //assert
            Assert.Equal(450, result);
        }
    }
}