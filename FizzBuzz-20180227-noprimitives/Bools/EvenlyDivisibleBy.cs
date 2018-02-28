using FizzBuzz_20180227_noprimitives.Ints;

namespace FizzBuzz_20180227_noprimitives.Bools
{
    public class EvenlyDivisibleBy : IBool
    {
        private static readonly IInt Zero = new IntOf(0);

        private readonly IBool _origin;

        public EvenlyDivisibleBy(IInt dividend, IInt divisor) : this(new EqualsInt(new RemainderInt(dividend, divisor), Zero)) { }

        public EvenlyDivisibleBy(IBool origin) => _origin = origin;

        public bool RawValue() => _origin.RawValue();
    }
}