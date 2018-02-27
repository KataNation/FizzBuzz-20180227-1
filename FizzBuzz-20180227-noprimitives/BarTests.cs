using FluentAssertions;
using NUnit.Framework;
using System;

namespace FizzBuzz_20180227_noprimitives
{
    [TestFixture]
    public class BarTests
    {
        [Test, Category("Unit")]
        public void GivenTwo_ShouldReturnTextOfOne()
        {
            FizzBuzz(new FizzBuzzInt(1)).Should().Be(new TextOf("1"));
        }

        [Test, Category("Unit")]
        public void GivenSix_ShouldReturnTextOfFizz()
        {
            FizzBuzz(new FizzBuzzInt(6)).Should().Be(new TextOf("Fizz"));
        }

        [Test, Category("Unit")]
        public void GivenTen_ShouldReturnTextOfBuzz()
        {
            FizzBuzz(new FizzBuzzInt(10)).Should().Be(new TextOf("Buzz"));
        }

        [Test, Category("Unit")]
        public void GivenFifteen_ShouldReturnTextOfFizzBuzz()
        {
            FizzBuzz(new FizzBuzzInt(15)).Should().Be(new TextOf("FizzBuzz"));
        }

        [Test, Category("Unit")]
        public void GivenThirty_ShouldReturnTextOfFizzBuzz()
        {
            FizzBuzz(new FizzBuzzInt(30)).Should().Be(new TextOf("FizzBuzz"));
        }

        private IText FizzBuzz(IFizzBuzzInt value)
        {
            if (value.IsEvenlyDivisibleByFifteen()) return new FizzBuzzText();
            if (value.IsEvenlyDivisibleByFive()) return new BuzzText();
            if (value.IsEvenlyDivisibleByThree()) return new FizzText();

            return value.Text();
        }
    }

    public class FizzBuzzText : IText
    {
        private static readonly IText FizzBuzz = new TextOf("FizzBuzz");
        public override bool Equals(object obj) => FizzBuzz.Equals(obj);

        public override int GetHashCode() => FizzBuzz.GetHashCode();
    }

    public class FizzBuzzInt : IFizzBuzzInt
    {
        private readonly int _origin;

        public FizzBuzzInt(int origin) => _origin = origin;
        public bool IsEvenlyDivisibleByThree() => _origin % 3 == 0;
        public bool IsEvenlyDivisibleByFive() => _origin % 5 == 0;
        public bool IsEvenlyDivisibleByFifteen() => IsEvenlyDivisibleByThree() && IsEvenlyDivisibleByFive();

        public IText Text() => new TextOf(_origin);
    }

    //public class ModInt
    //{
    //    public ModInt(int value, int mod)
    //    {
            
    //    }

    //    public int Value() => value % mod
    //}
    

    public interface IFizzBuzzInt
    {
        bool IsEvenlyDivisibleByThree();
        bool IsEvenlyDivisibleByFive();
        bool IsEvenlyDivisibleByFifteen();
        IText Text();
    }

    public class FizzText : IText
    {
        private static readonly IText Fizz = new TextOf("Fizz");
        public override bool Equals(object obj) => Fizz.Equals(obj);

        public override int GetHashCode() => Fizz.GetHashCode();
    }

    public class BuzzText : IText
    {
        private static readonly IText Buzz = new TextOf("Buzz");
        public override bool Equals(object obj) => Buzz.Equals(obj);

        public override int GetHashCode() => Buzz.GetHashCode();
    }

    public class TextOf : IText
    {
        private readonly Func<string> _origin;

        public TextOf(int origin) : this(origin.ToString) { }

        public TextOf(string origin):this(() => origin) { }

        private TextOf(Func<string> origin) => _origin = origin;

        public override bool Equals(object obj) => Equals((TextOf) obj);

        public override int GetHashCode() => (_origin() != null ? _origin().GetHashCode() : 0);

        public bool Equals(TextOf other) => other != null && this._origin() == other._origin();
    }
    

    public interface IText
    {
    }
}
