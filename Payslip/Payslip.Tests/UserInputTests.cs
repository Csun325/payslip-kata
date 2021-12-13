using System;
using Payslip.Interfaces;
using Xunit;

namespace Payslip.Tests
{
    public class UserInputTests
    {
        [Fact]
        public void ReadName_WhenNameInputIsString_ThenNameIsSetAsString()
        {
            //arrange
            var reader = new ReadConsoleInput(new MockGetInput()); 
            var firstName = "John";
            //action
            var actual = reader.ReadName();
            //assert
            Assert.Equal(firstName, actual);
        }

        [Fact]
        public void ReadNumber_WhenNumberIsStringInput_ThenGetNumberAsIntResult()
        {
            //arrange
            var reader = new ReadConsoleInput(new MockGetInput());
            var expected = 500;
            //action
            var actual = reader.ReadNumber();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReadDate_WhenInputIsDate_ThenGetDateAsString()
        {
            //arrange
            var reader = new ReadConsoleInput(new MockGetInput());
            var expected = "01 March";
            //action
            var actual = reader.ReadDate();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReadDate_WhenInputDateIsNull_ThenThrowException()
        {
            //arrange
            var reader = new ReadConsoleInput(new MockGetInput());
            //action
            //assert
            var exception = Assert.Throws<ArgumentException>(() => reader.ReadDate());
            Assert.Equal("Incorrect format, example = '01 March'", exception.Message);
        }

        [Fact]
        public void ReadDate_WhenDayIsLessThanZero_ThrowException()
        {
            //arrange
            var reader = new ReadConsoleInput(new MockGetInput());
            //action
            //assert
            var exception = Assert.Throws<ArgumentException>(() => reader.ReadDate());
            Assert.Equal("Incorrect format, example = '01 March'", exception.Message);
        }

        [Fact]
        public void ReadDate_WhenMonthIsIncorrect_ThenThrowException()
        {
            //arrange
            var reader = new ReadConsoleInput(new MockGetInput());
            //action
            //assert
            var exception = Assert.Throws<ArgumentException>(() => reader.ReadDate());
            Assert.Equal("Incorrect format, example = '01 March'", exception.Message);
        }
        
    }
}


