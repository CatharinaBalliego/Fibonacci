using Xunit;
using FluentAssertions;

namespace Fibonacci.Test
{
    public class FibonacciTest
    {
        [Theory]
        [InlineData(1, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        public void Check_NumberIsFibonacci_WhenNumberIsValid(int number, bool expected)
        {
            var sut = new Fibonacci();

            var result = sut.Check(number);

            result.Should().Be(expected);
        }
    }
}
