using FizzBuzz_20180227_noprimitives.Extensions;
using FizzBuzz_20180227_noprimitives.Ints;
using FizzBuzz_20180227_noprimitives.Texts;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz_20180227_noprimitives
{
    [TestFixture]
    public class BarTests
    {
        [Test, Category("Unit")]
        public void GivenTwo_ShouldReturnTextOfOne()
        {
            new StrategyFizzBuzz(new IntOf(1)).Response().IsEqual(new TextOf("1")).Should().BeTrue();
        }

        [Test, Category("Unit")]
        public void GivenSix_ShouldReturnTextOfFizz()
        {
            new StrategyFizzBuzz(new IntOf(6)).Response().IsEqual(new TextOf("Fizz")).Should().BeTrue();
        }

        [Test, Category("Unit")]
        public void GivenTen_ShouldReturnTextOfBuzz()
        {
            new StrategyFizzBuzz(new IntOf(10)).Response().IsEqual(new TextOf("Buzz")).Should().BeTrue();
        }

        [Test, Category("Unit")]
        public void GivenThirty_ShouldReturnTextOfFizzBuzz()
        {
            new StrategyFizzBuzz(new IntOf(30)).Response().IsEqual(new TextOf("FizzBuzz")).Should().BeTrue();
        }
    }
}
