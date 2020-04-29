using System;
using Xunit;
using Packt;


namespace CalculatorXUnitTests
{
    public class CalculatorUnitTests
    {
        [Fact]
        public void TestAdding2And2()
        {
            double a = 2;
            double b = 2;
            double expected = 4;
            Calculator calc = new Calculator();
            double actual  = calc.Add(a, b);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestAdding2and3()
        {
            double a = 2;
            double b = 3;
            double expected = 6;
            Calculator calc = new Calculator();
            double actual = calc.Add(a, b);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestAdding3And3()
        {
            Calculator calc = new Calculator();
            Assert.Equal(9, calc.Add(3, 3));
        }
    }
}
