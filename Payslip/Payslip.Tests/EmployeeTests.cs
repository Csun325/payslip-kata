using System;
using Xunit;

namespace Payslip.Tests
{
    public class EmployeeTests
    {
        private readonly Employee p1;
        public EmployeeTests()
        {
            p1 = new Employee(new MockReadConsoleInput(), new Calculator());
        }
        
        [Fact]
        public void GenerateInput_WhenInputIsGiven_SaveDataToClassFields()
        {
            //arrange
            //action
            p1.GenerateInput();
            //assert
            Assert.Equal("John", p1.firstName);
            Assert.Equal(500, p1.annualSalary);
            Assert.Equal("1 March", p1.startDate);
        }

        [Fact]
        public void IDK()
        {
            //arrange
            //action
            //assert
        }
    }
}