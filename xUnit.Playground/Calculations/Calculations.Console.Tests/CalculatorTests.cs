using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace Calculations.ConsoleApp.Tests
{
    public class CalculatorFixture:IDisposable
    {
        public Calculator calculator => new Calculator();

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    public class CalculatorTests : IClassFixture<CalculatorFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;  // for debugging output...
        private readonly CalculatorFixture _calculatorFixture;

        public CalculatorTests(ITestOutputHelper testOutputHelper, CalculatorFixture calcualtorFixture)
        {
            _calculatorFixture = calcualtorFixture;
            _testOutputHelper = testOutputHelper;
            _testOutputHelper.WriteLine("ctor init of CalculatorTests class");
        }

        [Fact]
        public void Add_GivenTwoIntegerValues_ReturnsSum()
        {
            var calc = _calculatorFixture.calculator;
            var result = calc.Add(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void AddDouble_GivenTwoDobuleValues_ReturnsSum()
        {
            var calc = _calculatorFixture.calculator;
            var result = calc.AddDouble(1.2, 3.4);
            Assert.Equal(4.6, result);
        }

        [Fact]
        public void FiboDoesNotIncludeZero()
        {
            var calc = _calculatorFixture.calculator;
            Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboInclude13()
        {
            var calc = _calculatorFixture.calculator;
            Assert.Contains(13, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboIDoesNotnclude4()
        {
            var calc = _calculatorFixture.calculator;
            Assert.DoesNotContain(4, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void CheckCollection()
        {
            var expectedList = new List<int>() { 1, 1, 2, 3, 5, 8, 13 };
            var calc = _calculatorFixture.calculator;
            Assert.Equal(expectedList, calc.FiboNumbers);
            _testOutputHelper.WriteLine("CheckCollection method has been run");
        }

        [Theory]
        //[InlineData(1, true)]
        //[InlineData(4, false)]
        //[MemberData(nameof(TestDataShare.IsOddOrEvenData), MemberType = typeof(TestDataShare))]
        [IsOddData]   // it can be used many places
        public void IsOdd_TestOddAndEven(int value, bool expected)
        {
            var calc = new Calculator();
            var result = calc.IsOdd(value);
            _testOutputHelper.WriteLine(result.ToString());

            Assert.Equal(result, expected);
        }
    }
}
